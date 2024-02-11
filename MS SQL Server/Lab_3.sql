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

/*Додавання стовпця:*/
ALTER TABLE Students
ADD Email NVARCHAR(100);

/*Зміна типу даних стовпця:*/
ALTER TABLE Students
ALTER COLUMN Number NVARCHAR(15);

/*Видалення стовпця:*/
ALTER TABLE Students
DROP COLUMN Email;

/*Додавання зовнішнього ключа:*/
ALTER TABLE GroupAssociation
ADD CONSTRAINT FK_GroupAssociation_Student
FOREIGN KEY (id) REFERENCES Students(id);

-- Вставка 25 студентів
INSERT INTO Students (SurName, Name, LastName, Sex, Date, Adress, Number, Consript)
VALUES
  ('Іванов', 'Олександр', 'Петрович', 'Ч', '1998-05-15', 'Дніпро, вул. Героїв АТО, 10', '+380501234567', 'Придатний'),
  ('Петров', 'Анна', 'Сергіївна', 'Ж', '1999-02-20', 'Дніпро, вул. Студентська, 25', '+380502345678', 'Придатний'),
  ('Іванов', 'Олег', 'Вікторович', 'Ч', '1998-03-15', 'Дніпро, вул. Героїв', '+380987654321',  'Придатний'),
  ('Петров', 'Анна', 'Ігорівна', 'Ж', '1999-07-22', 'Дніпро, вул. Леніна', '+380955556666', 'Непридатний'),
  /*5*/('Сидоренко', 'Максим', 'Ігорович', 'Ч', '1997-11-10', 'Дніпро, вул. Пушкіна', '+380933334444',  'Придатний'),
  ('Коваль', 'Марина', 'Олександрівна', 'Ж', '1998-05-03', 'Дніпро, вул. Шевченка', '+380971112233', 'Непридатний'),
  ('Лисенко', 'Артем', 'Андрійович', 'Ч', '1999-02-18', 'Дніпро, вул. Гагаріна', '+380988887777', 'Придатний'),
  ('Іванов', 'Олег', 'Володимирович', 'Ч', '1995-03-15', 'вул. Головна, 12, Дніпро', '+380501234567',  'Придатний'),
  ('Петров', 'Марія', 'Олександрівна', 'Ж', '1997-06-22', 'вул. Перша, 7, Дніпро', '+380502345678',  'Непридатний'),
  /*10*/('Сидоров', 'Анна', 'Ігорівна', 'Ж', '1998-09-10', 'вул. Друга, 24, Дніпро', '+380503456789',  'Придатний'),
  ('Коваленко', 'Ігор', 'Петрович', 'Ч', '1996-12-05', 'вул. Третя, 15, Дніпро', '+380504567890',  'Непридатний'),
  ('Мельник', 'Віталій', 'Ігорович', 'Ч', '1999-02-28', 'вул. Четверта, 18, Дніпро', '+380505678901', 'Придатний'),
  ('Іванов', 'Олег', 'Андрійович', 'Ч', '1998-05-15', 'вул. Головна, 123, Дніпро', '+380501234567', 'Придатний'),
  ('Петров', 'Марія', 'Василівна', 'Ж', '1999-02-28', 'вул. Садова, 45, Дніпро', '+380502345678', 'Придатний'),
  /*15*/('Сидоров', 'Ігор', 'Ігорович', 'Ч', '1997-09-10', 'вул. Пушкіна, 67, Дніпро', '+380503456789', 'Непридатний'),
  ('Іванов', 'Олександр', 'Ігорович', 'Ч', '1995-05-10', 'Дніпро, вул. Центральна, 1', '+380501112233', 'Придатний'),
  ('Петров', 'Анна', 'Миколаївна', 'Ж', '1998-07-15', 'Дніпро, вул. Перша, 5', '+380502223344', 'Не придатний'),
  ('Сидоренко', 'Ігор', 'Віталійович', 'Ч', '1997-01-20', 'Дніпро, вул. Друга, 10', '+380503334455', 'Придатний'),
  ('Коваленко', 'Марія', 'Андріївна', 'Ж', '1996-11-05', 'Дніпро, вул. Третя, 15', '+380504445566', 'Придатний'),
  /*20*/('Михайленко', 'Євген', 'Олексійович', 'Ч', '1999-03-25', 'Дніпро, вул. Четверта, 20', '+380505556677', 'Придатний'),
  -- Іноземні або іногородні студенти
  ('Smith', 'John', 'William', 'Ч', '1997-08-10', 'New York, USA', '+11234567890',   'Fit for service'),
  ('Garcia', 'Sofia', 'Maria', 'Ж', '1998-11-28', 'Barcelona, Spain', '+34678123456',  'Fit for service'),
  ('Kim', 'Jihoon', 'Minho', 'Ч', '1999-04-05', 'Seoul, South Korea', '+821012345678',  'Fit for service'),
  ('Chen', 'Wei', 'Yan', 'Ч', '1998-01-15', 'Beijing, China', '+8613887654321',  'Fit for service'),
  /*25*/('Müller', 'Lena', 'Marie', 'Ж', '1997-07-20', 'Berlin, Germany', '+4917198765432', 'Fit for service');

-- Вставка 20 предметів
INSERT INTO Subjects (Name)
VALUES
    ('Математика'),
    ('Фізика'),
    ('Українська мова'),
    ('Історія України'),
    ('Хімія'),
    ('Біологія'),
    ('Географія'),
    ('Іноземна мова'),
    ('Інформатика'),
    ('Фізра'),
    ('Економіка'),
    ('Інженерія'),
    ('Психологія'),
    ('Музика'),
    ('Мистецтво'),
    ('Соціологія'),
    ('Мовознавство'),
    ('Філософія'),
    ('Правознавство'),
    ('Медицина');


SET IDENTITY_INSERT StudentSubjectGrades ON;
	DECLARE @StudentID INT = 3;
	DECLARE @Counter INT = 1;
DECLARE @SubjectID INT;

-- Цикл для кожного студента
WHILE @StudentID <= 28
BEGIN
    SET @SubjectID = 1;

    -- Цикл для кожного предмету
    WHILE @SubjectID <= 20
    BEGIN
        INSERT INTO StudentSubjectGrades (id, StudentID, SubjectID, Grade)
        VALUES (@Counter, @StudentID, @SubjectID, CAST(RAND() * 100 AS INT));

        SET @SubjectID = @SubjectID + 1;
    END;

	SET @Counter = @Counter + 1;
    SET @StudentID = @StudentID + 1;
END;
SET IDENTITY_INSERT StudentSubjectGrades OFF;

-- Вставка даних в таблицю Professors 5 викладачів.
INSERT INTO Professors (id, Surname, Name, LastName, Degree, Title, Position)
VALUES
('3','Ivanov', 'Ivan', 'Ivanovich', 'Ph.D.', 'Associate Professor', 'Mathematics Department'),
('4','Petrov', 'Petr', 'Petrovich', 'Ph.D.', 'Assistant Professor', 'Physics Department'),
('5','Sidorov', 'Sidor', 'Sidorovich', 'D.Sc.', 'Professor', 'Chemistry Department'),
('6','Kozlov', 'Alexey', 'Ivanovich', 'Ph.D.', 'Associate Professor', 'Computer Science Department'),
('7','Zaitsev', 'Nikolay', 'Nikolaevich', 'D.Sc.', 'Professor', 'Biology Department');

--10 статтей (5 - спільні з викладачами);
INSERT INTO Articles(Title, Date)
VALUES
('Article 1', '2023-01-01'),
('Article 2', '2023-02-01'),
('Article 3', '2023-03-01'),
('Article 4', '2023-04-01'),
('Article 5', '2023-05-01'),
('Article 6', '2023-06-01'),
('Article 7', '2023-07-01'),
('Article 8', '2023-08-01'),
('Article 9', '2023-09-01'),
('Article 10', '2023-10-01');

-- Включить IDENTITY_INSERT для ArticleProfessorsAssociation
SET IDENTITY_INSERT ArticleProfessorsAssociation ON;

DECLARE @Counter INT = 1;
DECLARE @PROFESSOR INT = 1;
WHILE @Counter <= 10
BEGIN
	
	IF (@PROFESSOR >= 7)
		SET @PROFESSOR = 1;
	
    INSERT INTO ArticleProfessorsAssociation(id, ProffesorID, ArticleID)
    VALUES
    (@Counter, @PROFESSOR, @Counter + 1001);

    SET @Counter = @Counter + 1;
	SET @PROFESSOR = @PROFESSOR + 1;
END;

-- Выключить IDENTITY_INSERT для ArticleProfessorsAssociation
SET IDENTITY_INSERT ArticleProfessorsAssociation OFF;

-- Включить IDENTITY_INSERT для ArticleStudentAssociation
SET IDENTITY_INSERT ArticleStudentAssociation ON;

DECLARE @CounterStudent INT = 1;
WHILE @CounterStudent <= 10
BEGIN
    INSERT INTO ArticleStudentAssociation(id, StudentID, ArticleID)
    VALUES
    (@CounterStudent, @CounterStudent + 3, @CounterStudent + 1001);

    SET @CounterStudent = @CounterStudent + 1;
END;

-- Выключить IDENTITY_INSERT для ArticleStudentAssociation
SET IDENTITY_INSERT ArticleStudentAssociation OFF;


-- Вставка 10 записів в таблицю ConferencePaper
INSERT INTO ConferencePapers(Title, Date)
VALUES
('Paper 1', '2023-11-09'),
('Paper 2', '2023-11-10'),
('Paper 3', '2023-11-11'),
('Paper 4', '2023-11-12'),
('Paper 5', '2023-11-13'),
('Paper 6', '2023-11-14'),
('Paper 7', '2023-11-15'),
('Paper 8', '2023-11-16'),
('Paper 9', '2023-11-17'),
('Paper 10', '2023-11-18');


DECLARE @Counter_ INT = 1;
DECLARE @PROFESSOR_2 INT = 1;

-- Enable IDENTITY_INSERT for PaperStudentAssociation
SET IDENTITY_INSERT Lab_2.dbo.PaperStudentAssociation ON;

WHILE @Counter_ <= 10
BEGIN
    -- Вставка данных в PaperStudentAssociation
    INSERT INTO Lab_2.dbo.PaperStudentAssociation (id, StudentID, PaperID)
    VALUES
    (@Counter_, @Counter_ + 2, @Counter_);

    SET @Counter_ = @Counter_ + 1;
END;

-- Disable IDENTITY_INSERT for PaperStudentAssociation
SET IDENTITY_INSERT Lab_2.dbo.PaperStudentAssociation OFF;

SET @Counter_ = 1; -- Reset counter

-- Enable IDENTITY_INSERT for PaperProfessorsAssociation
SET IDENTITY_INSERT Lab_2.dbo.PaperProfessorsAssociation ON;

WHILE @Counter_ <= 10
BEGIN
    -- Вставка данных в PaperProfessorsAssociation
    INSERT INTO Lab_2.dbo.PaperProfessorsAssociation (id, ProfessorID, PaperID)
    VALUES
    (@Counter_, @PROFESSOR_2, @Counter_);
	IF @PROFESSOR_2 >= 7
		SET @PROFESSOR_2 = 1;
    SET @Counter_ = @Counter_ + 1;
    SET @PROFESSOR_2 = @PROFESSOR_2 + 1;
END
SET IDENTITY_INSERT Lab_2.dbo.PaperProfessorsAssociation OFF;



