/*Лаб 4. Розробити SQL запити, які виконують наступні дії:
1 Додати обмеження для значень, що вводяться, у поле форма навчання з таблиці groups з використанням команди ALTER TABLE.
2 Вивести на екран П.І.Б. (прізвище - повністю, ім'я та по батькові - скорочено) 
				всіх студентів, що живуть у гуртожитку.
3 Вивести на екран П.І.Б. (прізвище - повністю, ім'я та по батькові - скорочено) 
				всіх військовозобов'язаних студентів (чоловіка, 18<= вік < 25, придатні до військової служби).
4 Вивести на екран П.І.Б. (прізвище - повністю, ім'я та по батькові - скорочено) 
				і № курсу всіх студентів, які
5 Вивести на екран П.І.Б. (прізвище - повністю, ім'я та по батькові - скорочено) 
				і групу всіх студентів, що мають друковані праці (статті та тези), а також назви цих друкованих праць і їх тип (стаття або тези).
6 Вивести перелік предметів і оцінки по них для зазначеного студента (студент вибирається по номеру залікової).
7 Використовуючи common table expressions одержати наступні дані: назва предмета, код спеціальності, номер курсу.
*/

--подивитись таблиці
SELECT * FROM [Lab_2].[dbo].[ArticleStudentAssociation];
SELECT * FROM [Lab_2].[dbo].[ArticleProfessorsAssociation];
SELECT * FROM [Lab_2].[dbo].[Articles];
SELECT * FROM [Lab_2].[dbo].[ConferencePapers];
SELECT * FROM [Lab_2].[dbo].[GroupAssociation];
SELECT * FROM [Lab_2].[dbo].[Groups];
SELECT * FROM [Lab_2].[dbo].[PaperProfessorsAssociation];
SELECT * FROM [Lab_2].[dbo].[PaperStudentAssociation];
SELECT * FROM [Lab_2].[dbo].[Professors];
SELECT * FROM [Lab_2].[dbo].[Students];
SELECT * FROM [Lab_2].[dbo].[StudentSubjectGrades];
SELECT * FROM [Lab_2].[dbo].[Subjects];


--заполним группы для взаимодействия
INSERT INTO [Lab_2].[dbo].[Groups] (GroupName, StudyType)
VALUES
    ('KS-22', 'full-time'),
    ('KI-22', 'part-time'),
    ('KM-22', 'full-time'),
    ('KE-22', 'part-time'),
    ('KS-23-1', 'full-time'),
    ('KI-23-1', 'part-time'),
    ('KM-23-1', 'full-time'),
    ('KE-23-1', 'part-time'),
    ('KS-23-2', 'full-time'),
    ('KI-23-2', 'part-time'),
    ('KM-23-2', 'full-time'),
    ('KE-23-2', 'part-time');
  
--вставка груп
DECLARE @StudentStartPosition INT = 3;
DECLARE @StudentID INT = @StudentStartPosition;
DECLARE @InsertedStudents INT = 25;
DECLARE @GroupID INT = 1;
DECLARE @GroupMAX INT = 12;
DECLARE @PaymentType NVARCHAR(10);

WHILE @StudentID <= @InsertedStudents + @StudentID  -- або яке завгодно максимальне значення ID студента
BEGIN
    -- Генеруємо випадковим чином PaymentType для кожного студента
    SET @PaymentType = CASE WHEN RAND() > 0.5 THEN 1 ELSE 0 END;

    -- Вставляємо запис у таблицю GroupsAssociation
    INSERT INTO [Lab_2].[dbo].[GroupAssociation] (StudentID, GroupID, PaymentType)
    VALUES (@StudentID, @GroupID, @PaymentType);

    -- Збільшуємо значення StudentID та GroupID
    SET @StudentID = @StudentID + 1;
    SET @GroupID = @GroupID + 1;

    -- Перевірка, чи не досягнуто максимального значення ID студента
	IF @StudentID >= @InsertedStudents + @StudentStartPosition
		BREAK;

    IF @GroupID > @GroupMAX  
        SET @GroupID = 1;
END;

--додаємо правило (з1)
ALTER TABLE [Lab_2].[dbo].[Groups]
ADD CONSTRAINT chk_form_of_study CHECK (StudyType IN ('full-time', 'part-time'));

--додаємо 5 студентів з гуртожику
INSERT INTO [Lab_2].[dbo].[Students] (SurName, Name, LastName, Sex, Date, Adress, Number, Consript)
VALUES
  ('Шейко', 'Олександр', 'Петрович', 'Ч', '2003-05-15', 'Дніпро, вул. Казакова, 38', '+380501234567', 'Придатний'),
  ('Ряженко', 'Анна', 'Сергіївна', 'Ж', '2000-02-20', 'Дніпро, вул. Казакова, 38', '+380502345678', 'Придатний'),
  ('Коломоєць', 'Олег', 'Вікторович', 'Ч', '2001-03-15', 'Дніпро, вул. Казакова, 38', '+380987654321',  'Придатний'),
  ('Ляшенко', 'Анна', 'Ігорівна', 'Ж', '2004-07-22', 'Дніпро, вул. Казакова, 38', '+380955556666', 'Непридатний'),
  /*5*/('Ляшко', 'Максим', 'Ігорович', 'Ч', '2005-11-10', 'Дніпро, вул. Казакова, 38', '+380933334444',  'Придатний');

--2 Вивести на екран П.І.Б. (прізвище - повністю, ім'я та по батькові - скорочено) всіх студентів, що живуть у гуртожитку.
SELECT CONCAT(Surname, ' ', LEFT(Name, 1), '.', LEFT(LastName, 1), '.') AS 'П.І.Б.'
FROM [Lab_2].[dbo].[Students]
WHERE Adress LIKE '%Дніпро, вул. Казакова%';

--3 Вивести на екран П.І.Б. (прізвище - повністю, ім'я та по батькові - скорочено) всіх військовозобов'язаних студентів (чоловіка, 18<= вік < 25, придатні до військової служби).
SELECT CONCAT(Surname, ' ', LEFT(Name, 1), '.', LEFT(LastName, 1), '.') AS 'П.І.Б.',
	   DATEDIFF(YEAR, Date, GETDATE()) AS 'Вік'
FROM [Lab_2].[dbo].[Students]
WHERE Sex = 'Ч'
AND  DATEDIFF(YEAR, Date, GETDATE()) BETWEEN 18 AND 24
AND Consript = 'Придатний'

-- 4 Вивести на екран П.І.Б. (прізвище - повністю, ім'я та по батькові - скорочено) і № курсу всіх студентів, які
SELECT
    CONCAT(S.Surname, ' ', S.Name, ' ', LEFT(S.LastName, 1)) AS 'П.І.Б.',
    SUBSTRING(G.GroupName, CHARINDEX('-', G.GroupName) + 1, 2) AS '№ курсу'
FROM [Lab_2].[dbo].[Students] AS S
JOIN [Lab_2].[dbo].GroupAssociation AS GA ON S.id = GA.StudentID
JOIN [Lab_2].[dbo].[Groups] AS G ON GA.GroupID = G.id
WHERE G.GroupName LIKE 'KS%'

-- 5 Вивести на екран П.І.Б. (прізвище - повністю, ім'я та по батькові - скорочено) 
--				і групу всіх студентів, що мають друковані праці (статті та тези), а також назви цих друкованих праць і їх тип (стаття або тези).
-- Вивести на екран П.І.Б. інформацію про всіх студентів, незалежно від наявності друкованих праць
SELECT
    CONCAT(S.SurName, ' ', S.Name, ' ', LEFT(S.LastName, 1)) AS 'П.І.Б.',
    G.GroupName AS 'Група',
    CASE
        WHEN PSA.PaperID IS NOT NULL THEN 'Тези'
        WHEN ASA.ArticleID IS NOT NULL THEN 'Стаття'
        ELSE 'Немає друкованих праць'
    END AS 'Тип праці',
    COALESCE(AA.Title, CP.Title) AS 'Назва друкованої праці'
FROM [Lab_2].[dbo].Students AS S
JOIN [Lab_2].[dbo].GroupAssociation AS GA ON S.id = GA.StudentID
JOIN [Lab_2].[dbo].Groups AS G ON GA.GroupID = G.id
LEFT JOIN [Lab_2].[dbo].ArticleStudentAssociation AS ASA ON S.id = ASA.StudentID
LEFT JOIN [Lab_2].[dbo].Articles AS AA ON ASA.ArticleID = AA.id
LEFT JOIN [Lab_2].[dbo].PaperStudentAssociation AS PSA ON S.id = PSA.StudentID
LEFT JOIN [Lab_2].[dbo].ConferencePapers AS CP ON PSA.PaperID = CP.id;

-- Вивести на екран П.І.Б. інформацію про студентів з друкованими працями
SELECT
    CONCAT(S.SurName, ' ', S.Name, ' ', LEFT(S.LastName, 1)) AS 'П.І.Б.',
    G.GroupName AS 'Група',
    CASE
        WHEN PSA.PaperID IS NOT NULL THEN 'Тези'
        WHEN ASA.ArticleID IS NOT NULL THEN 'Стаття'
        ELSE 'Немає друкованих праць'
    END AS 'Тип праці',
    COALESCE(AA.Title, CP.Title) AS 'Назва друкованої праці'
FROM [Lab_2].[dbo].Students AS S
JOIN [Lab_2].[dbo].GroupAssociation AS GA ON S.id = GA.StudentID
JOIN [Lab_2].[dbo].Groups AS G ON GA.GroupID = G.id
LEFT JOIN [Lab_2].[dbo].ArticleStudentAssociation AS ASA ON S.id = ASA.StudentID
LEFT JOIN [Lab_2].[dbo].Articles AS AA ON ASA.ArticleID = AA.id
LEFT JOIN [Lab_2].[dbo].PaperStudentAssociation AS PSA ON S.id = PSA.StudentID
LEFT JOIN [Lab_2].[dbo].ConferencePapers AS CP ON PSA.PaperID = CP.id
WHERE ASA.ArticleID IS NOT NULL OR PSA.PaperID IS NOT NULL;


--6 Вивести перелік предметів і оцінки по них для зазначеного студента (студент вибирається по номеру залікової).
SELECT
    S.SurName + ' ' + LEFT(S.Name, 1) + '. ' + LEFT(S.LastName, 1) + '.' AS 'П.І.Б.',
    Su.Name AS 'Предмет',
    SSG.Grade AS 'Оцінка'
FROM [Lab_2].[dbo].Students AS S
JOIN [Lab_2].[dbo].StudentSubjectGrades AS SSG ON S.id = SSG.StudentID
JOIN [Lab_2].[dbo].Subjects AS Su ON SSG.SubjectID = Su.id
WHERE S.id = 3;--тут id залікової

--7 Використовуючи common table expressions одержати наступні дані: назва предмета, код спеціальності, номер курсу.
WITH StudentInfo AS (
    SELECT
        S.id AS StudentID,
        G.GroupName,
        (YEAR(GETDATE()) - CAST(SUBSTRING(G.GroupName, 4, 2) AS INT) + 1) - 2000 AS CourseNumber 
    FROM [Lab_2].[dbo].Students AS S
    JOIN [Lab_2].[dbo].GroupAssociation AS GA ON S.id = GA.StudentID
    JOIN [Lab_2].[dbo].Groups AS G ON GA.GroupID = G.id
)

SELECT DISTINCT
    Su.Name AS SubjectName,
    SUBSTRING(GA.GroupName, 1, CHARINDEX('-', GA.GroupName) - 1) AS SpecialtyCode,
    SI.CourseNumber
FROM StudentInfo AS SI
JOIN [Lab_2].[dbo].StudentSubjectGrades AS SSG ON SI.StudentID = SSG.StudentID
JOIN [Lab_2].[dbo].Subjects AS Su ON SSG.SubjectID = Su.id
JOIN [Lab_2].[dbo].Groups AS GA ON SI.GroupName = GA.GroupName;


