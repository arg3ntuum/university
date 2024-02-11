/* Лаб 5
1. Створити таблицю, що містить П.І.Б. (прізвище - повністю, ім'я та по батькові - скорочено) 
	і групу всіх студентів, які можуть стати фахівцями (4 - ий курс, 3<= середній бал <= 4.56). При виконанні завдання використовувати курсори.
2. Вивести на екран П.І.Б. (прізвище - повністю, ім'я та по батькові - скорочено)
	і групу всіх студентів, які мають заборгованості (негативну оцінку по якому-небудь предмету). При виконанні завдання використовувати курсори.
3. Вивести на екран П.І.Б. (прізвище - повністю, ім'я та по батькові - скорочено
	і групу всіх студентів, які мають 3 заборгованості (негативну оцінку по якому-небудь предметі) і
	для кожного студента список предметів, по яких у нього заборгованості, а також отриману ним негативну оцінку. 
	При виконанні завдання використовувати курсори.
4. Вивести на екран П.І.Б. (прізвище - повністю, ім'я та по батькові - скорочено)
	і посаду викладача, у якого найбільше статей, а також назви статей і список співавторів для кожної статті.
	При виконанні завдання використовувати курсори.
5. Вивести на екран П.І.Б. (прізвище - повністю, ім'я та по батькові - скорочено)
	всіх студентів, які вчаться в 2 або більше групах (наприклад, учаться на денному і вечірньому відділеннях),
	а також назви груп для кожного студента, у яких він учиться. Знайти одну з найбільш популярних спеціальностей (її код),
	що люблять одержувати студенти в якості додатковоїо (другої) вищої освіти. При виконанні завдання використовувати курсори.
*/


--1. Створити таблицю, що містить П.І.Б. (прізвище - повністю, ім'я та по батькові - скорочено) 
--	і групу всіх студентів, які можуть стати фахівцями (4 - ий курс, 3<= середній бал <= 4.56). При виконанні завдання використовувати курсори.
/*через те, що в таблиці 100 бальна система, було змінено умову на IF @AverageGrade >= 40 AND @AverageGrade <= 100*/
-- Створення таблиці
CREATE TABLE QualifiedStudents (
    FullName NVARCHAR(255),
    GroupName NVARCHAR(50)
);

-- Оголошення змінних для курсора
DECLARE @StudentID INT, @SurName NVARCHAR(50), @Name NVARCHAR(50), @LastName NVARCHAR(50),
        @GroupID INT, @AverageGrade DECIMAL(4, 2);

-- Оголошення та відкриття курсора
DECLARE StudentCursor CURSOR FOR
SELECT
    S.id,
    S.SurName,
    S.Name,
    S.LastName,
    GA.GroupID,
    AVG(SSG.Grade) AS AverageGrade
FROM Lab_2.dbo.Students AS S
JOIN Lab_2.dbo.GroupAssociation AS GA ON S.id = GA.StudentID
JOIN Lab_2.dbo.StudentSubjectGrades AS SSG ON S.id = SSG.StudentID
WHERE GA.PaymentType = 0 
GROUP BY S.id, S.SurName, S.Name, S.LastName, GA.GroupID
HAVING COUNT(SSG.SubjectID) > 0; -- якщо студент має хоча б одну оцінку

OPEN StudentCursor;

-- Зчитування даних з курсора та вставка в таблицю
FETCH NEXT FROM StudentCursor INTO @StudentID, @SurName, @Name, @LastName, @GroupID, @AverageGrade;

WHILE @@FETCH_STATUS = 0
BEGIN
    IF @AverageGrade >= 40 AND @AverageGrade <= 100
    BEGIN
        INSERT INTO QualifiedStudents (FullName, GroupName)
        VALUES (CONCAT(@SurName, ' ', @Name, ' ', LEFT(@LastName, 1)), (SELECT GroupName FROM Lab_2.dbo.Groups WHERE id = @GroupID));
    END

    FETCH NEXT FROM StudentCursor INTO @StudentID, @SurName, @Name, @LastName, @GroupID, @AverageGrade;
END

CLOSE StudentCursor;
DEALLOCATE StudentCursor;

SELECT * FROM QualifiedStudents;
DROP TABLE QualifiedStudents;



--2. Вивести на екран П.І.Б. (прізвище - повністю, ім'я та по батькові - скорочено)
--	і групу всіх студентів, які мають заборгованості (негативну оцінку по якому-небудь предмету). При виконанні завдання використовувати курсори.


-- Створення таблиці
CREATE TABLE StudentsWithDebts (
    FullName NVARCHAR(255),
    GroupName NVARCHAR(50)
);

-- Оголошення змінних для курсора
DECLARE @StudentID_t2 INT, @SurName_t2 NVARCHAR(50), @Name_t2 NVARCHAR(50), @LastName_t2 NVARCHAR(50), @GroupID_t2 INT, @SubjectID_t2 INT, @Grade_t2 DECIMAL(4, 2);

-- Оголошення та відкриття курсора
DECLARE StudentDebtCursor CURSOR FOR
SELECT
    S.id,
    S.SurName,
    S.Name,
    S.LastName,
    GA.GroupID,
    SSG.SubjectID,
    SSG.Grade
FROM Lab_2.dbo.Students AS S
JOIN Lab_2.dbo.GroupAssociation AS GA ON S.id = GA.StudentID
JOIN Lab_2.dbo.StudentSubjectGrades AS SSG ON S.id = SSG.StudentID
WHERE SSG.Grade < 60; --  умовa наявності заборгованостей

OPEN StudentDebtCursor;

-- Зчитування даних з курсора та вставка в таблицю
FETCH NEXT FROM StudentDebtCursor INTO @StudentID_t2, @SurName_t2, @Name_t2, @LastName_t2, @GroupID_t2, @SubjectID_t2, @Grade_t2;

WHILE @@FETCH_STATUS = 0
BEGIN
    INSERT INTO StudentsWithDebts (FullName, GroupName)
    VALUES (CONCAT(@SurName_t2, ' ', @Name_t2, ' ', LEFT(@LastName_t2, 1)), (SELECT GroupName FROM Lab_2.dbo.Groups WHERE id = @GroupID_t2));

    FETCH NEXT FROM StudentDebtCursor INTO @StudentID_t2, @SurName_t2, @Name_t2, @LastName_t2, @GroupID_t2, @SubjectID_t2, @Grade_t2;
END

CLOSE StudentDebtCursor;
DEALLOCATE StudentDebtCursor;

-- Перегляд таблиці студентів з заборгованостями
SELECT * FROM StudentsWithDebts;


--3. Вивести на екран П.І.Б. (прізвище - повністю, ім'я та по батькові - скорочено
--	і групу всіх студентів, які мають 3 заборгованості (негативну оцінку по якому-небудь предметі) і
--	для кожного студента список предметів, по яких у нього заборгованості, а також отриману ним негативну оцінку. 
--	При виконанні завдання використовувати курсори.

-- Створення таблиці
CREATE TABLE StudentsWithDebtsAndGrades (
    FullName NVARCHAR(255),
    GroupName NVARCHAR(50),
    SubjectName NVARCHAR(255),
    DebtGrade DECIMAL(4, 2)
);

-- Оголошення змінних для курсора
DECLARE @StudentID_t3 INT, @SurName_t3 NVARCHAR(50), @Name_t3 NVARCHAR(50), @LastName_t3 NVARCHAR(50),
        @GroupID_t3 INT, @SubjectID_t3 INT, @Grade_t3 DECIMAL(4, 2), @DebtCount_t3 INT = 0;

-- Оголошення та відкриття курсора
DECLARE StudentDebtCursor CURSOR FOR
SELECT
    S.id,
    S.SurName,
    S.Name,
    S.LastName,
    GA.GroupID,
    SSG.SubjectID,
    SSG.Grade
FROM Lab_2.dbo.Students AS S
JOIN Lab_2.dbo.GroupAssociation AS GA ON S.id = GA.StudentID
JOIN Lab_2.dbo.StudentSubjectGrades AS SSG ON S.id = SSG.StudentID
WHERE SSG.Grade < 60; -- ви можете змінити це на вашу умову наявності заборгованостей

OPEN StudentDebtCursor;

-- Зчитування даних з курсора та вставка в таблицю
FETCH NEXT FROM StudentDebtCursor INTO @StudentID_t3, @SurName_t3, @Name_t3, @LastName_t3, @GroupID_t3, @SubjectID_t3, @Grade_t3;

WHILE @@FETCH_STATUS = 0
BEGIN
    -- Якщо студент має 3 заборгованості
    IF @DebtCount_t3 < 3
    BEGIN
        INSERT INTO StudentsWithDebtsAndGrades (FullName, GroupName, SubjectName, DebtGrade)
        VALUES (CONCAT(@SurName_t3, ' ', @Name_t3, ' ', LEFT(@LastName_t3, 1)), 
                (SELECT GroupName FROM Lab_2.dbo.Groups WHERE id = @GroupID_t3),
                (SELECT Name FROM Lab_2.dbo.Subjects WHERE id = @SubjectID_t3),
                @Grade_t3);
        
        SET @DebtCount_t3 = @DebtCount_t3 + 1;
    END
    ELSE
    BEGIN
        -- Якщо заборгованостей більше 3, обнуляємо лічильник
        SET @DebtCount_t3 = 0;
    END

    FETCH NEXT FROM StudentDebtCursor INTO @StudentID_t3, @SurName_t3, @Name_t3, @LastName_t3, @GroupID_t3, @SubjectID_t3, @Grade_t3;
END

CLOSE StudentDebtCursor;
DEALLOCATE StudentDebtCursor;

-- Перегляд таблиці студентів з заборгованостями та оцінками
SELECT * FROM StudentsWithDebtsAndGrades;


--4. Вивести на екран П.І.Б. (прізвище - повністю, ім'я та по батькові - скорочено)
--	і посаду викладача, у якого найбільше статей, а також назви статей і список співавторів для кожної статті.
--	При виконанні завдання використовувати курсори.

-- Створення таблиці
CREATE TABLE ProfessorWithMostArticles (
    FullName NVARCHAR(255),
    Position NVARCHAR(50),
    ArticleTitle NVARCHAR(255),
    CoAuthors NVARCHAR(255)
);

DECLARE @ProfessorID_t4 INT, @Surname_t4 NVARCHAR(50), @Name_t4 NVARCHAR(50), @LastName_t4 NVARCHAR(50),
        @Degree_t4 NVARCHAR(50), @Title_t4 NVARCHAR(50), @Position_t4 NVARCHAR(50), @ArticleID_t4 INT,
        @ArticleTitle_t4 NVARCHAR(255), @CoAuthors_t4 NVARCHAR(255), @MaxArticleCount_t4 INT = 0;

-- Оголошення та відкриття курсора
DECLARE ProfessorArticleCursor CURSOR FOR
SELECT
    P.id,
    P.Surname,
    P.Name,
    P.LastName,
    P.Degree,
    P.Title,
    P.Position,
    A.id AS ArticleID,
    A.Title AS ArticleTitle
FROM Lab_2.dbo.Professors AS P
LEFT JOIN Lab_2.dbo.ArticleProfessorsAssociation AS APA ON P.id = APA.ProffesorID
LEFT JOIN Lab_2.dbo.Articles AS A ON APA.ArticleID = A.id;

OPEN ProfessorArticleCursor;

-- Зчитування даних з курсора та вставка в таблицю
FETCH NEXT FROM ProfessorArticleCursor INTO @ProfessorID_t4, @Surname_t4, @Name_t4, @LastName_t4, @Degree_t4, @Title_t4, @Position_t4, @ArticleID_t4, @ArticleTitle_t4;

WHILE @@FETCH_STATUS = 0
BEGIN
    -- Отримання співавторів для статті
    SET @CoAuthors_t4 = STUFF((
        SELECT ', ' + S.Name + ' ' + S.LastName
        FROM Lab_2.dbo.ArticleStudentAssociation AS ASA
        JOIN Lab_2.dbo.Students AS S ON ASA.StudentID = S.id
        WHERE ASA.ArticleID = @ArticleID_t4
        FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, '');

    -- Знаходження викладача з найбільшою кількістю статей
    DECLARE @ArticleCount_t4 INT;
    SET @ArticleCount_t4 = (SELECT COUNT(*) FROM Lab_2.dbo.ArticleProfessorsAssociation WHERE ProffesorID = @ProfessorID_t4);

    IF @ArticleCount_t4 > @MaxArticleCount_t4
    BEGIN
        SET @MaxArticleCount_t4 = @ArticleCount_t4;

        -- Вставка даних в таблицю
        INSERT INTO ProfessorWithMostArticles (FullName, Position, ArticleTitle, CoAuthors)
        VALUES (CONCAT(@Surname_t4, ' ', @Name_t4, ' ', @LastName_t4), @Position_t4, @ArticleTitle_t4, @CoAuthors_t4);
    END

    FETCH NEXT FROM ProfessorArticleCursor INTO @ProfessorID_t4, @Surname_t4, @Name_t4, @LastName_t4, @Degree_t4, @Title_t4, @Position_t4, @ArticleID_t4, @ArticleTitle_t4;
END

CLOSE ProfessorArticleCursor;
DEALLOCATE ProfessorArticleCursor;



-- Перегляд таблиці викладачів з найбільшою кількістю статей
SELECT * FROM ProfessorWithMostArticles;


--5. Вивести на екран П.І.Б. (прізвище - повністю, ім'я та по батькові - скорочено)
--всіх студентів, які вчаться в 2 або більше групах (наприклад, учаться на денному і вечірньому відділеннях),
--а також назви груп для кожного студента, у яких він учиться. Знайти одну з найбільш популярних спеціальностей (її код), 
--що люблять одержувати студенти в якості додатковоїо (другої) вищої освіти. При виконанні завдання використовувати курсори.

-- Створення таблиці
CREATE TABLE StudentsInMultipleGroups (
    FullName NVARCHAR(255),
    GroupNames NVARCHAR(MAX)
);

-- Оголошення змінних для курсора
DECLARE @StudentID_t5 INT, @SurName_t5 NVARCHAR(50), @Name_t5 NVARCHAR(50), @LastName_t5 NVARCHAR(50),
        @GroupNames_t5 NVARCHAR(MAX);

-- Оголошення та відкриття курсора
DECLARE StudentMultipleGroupsCursor CURSOR FOR
SELECT
    S.id,
    S.SurName,
    S.Name,
    S.LastName,
    STUFF((
        SELECT ', ' + G.GroupName
        FROM Lab_2.dbo.GroupAssociation AS GA
        JOIN Lab_2.dbo.Groups AS G ON GA.GroupID = G.id
        WHERE GA.StudentID = S.id
        FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, '') AS GroupNames
FROM Lab_2.dbo.Students AS S
JOIN Lab_2.dbo.GroupAssociation AS GA ON S.id = GA.StudentID
GROUP BY S.id, S.SurName, S.Name, S.LastName
HAVING COUNT(DISTINCT GA.GroupID) >= 2;

OPEN StudentMultipleGroupsCursor;

-- Зчитування даних з курсора та вставка в таблицю
FETCH NEXT FROM StudentMultipleGroupsCursor INTO @StudentID_t5, @SurName_t5, @Name_t5, @LastName_t5, @GroupNames_t5;

WHILE @@FETCH_STATUS = 0
BEGIN
    INSERT INTO StudentsInMultipleGroups (FullName, GroupNames)
    VALUES (CONCAT(@SurName_t5, ' ', @Name_t5, ' ', @LastName_t5), @GroupNames_t5);

    FETCH NEXT FROM StudentMultipleGroupsCursor INTO @StudentID_t5, @SurName_t5, @Name_t5, @LastName_t5, @GroupNames_t5;
END

CLOSE StudentMultipleGroupsCursor;
DEALLOCATE StudentMultipleGroupsCursor;

-- Перегляд таблиці студентів, які вчаться в 2 або більше групах
SELECT * FROM StudentsInMultipleGroups;

-- Знайдемо одну з найбільш популярних спеціальностей
SELECT TOP 1
    LEFT(G.GroupName, 2) AS PopularSpecialty,
    COUNT(GA.StudentID) AS StudentCount
FROM Lab_2.dbo.Groups AS G
JOIN Lab_2.dbo.GroupAssociation AS GA ON G.id = GA.GroupID
GROUP BY LEFT(G.GroupName, 2)
ORDER BY StudentCount DESC;

