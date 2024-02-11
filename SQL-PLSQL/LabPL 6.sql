DROP TABLE FIO_STATISTICS;
DROP TABLE FIO_MilitaryService;
DROP TABLE BSO_STUDENTS;

CREATE TABLE BSO_STUDENTS (
    id NUMBER PRIMARY KEY,
    last_name VARCHAR2(50) NOT NULL,
    first_name VARCHAR2(50) NOT NULL,
    middle_name VARCHAR2(50) NOT NULL,
    birth_date DATE NOT NULL,
    gender CHAR(1) NOT NULL,
    military_service NUMBER(1,0)
);
CREATE TABLE FIO_STATISTICS (
    gender CHAR(1) NOT NULL,
    max_age NUMBER,
    min_age NUMBER,
    avg_age NUMBER,
    num_people NUMBER,
    CONSTRAINT pk_fio_statistics PRIMARY KEY (gender)
);

CREATE TABLE FIO_MilitaryService (
    student_id NUMBER,
    last_name VARCHAR2(50),
    first_name VARCHAR2(50),
    middle_name VARCHAR2(50),
    birth_date DATE,
    gender CHAR(1),
    military_service NUMBER(1,0),
    CONSTRAINT pk_fio_military_service PRIMARY KEY (student_id),
    CONSTRAINT fk_fio_military_service FOREIGN KEY (student_id)
        REFERENCES BSO_STUDENTS (id)
);

INSERT INTO BSO_STUDENTS (id, last_name, first_name, middle_name, birth_date, gender, military_service)
VALUES (1, 'Іванов', 'Олександр', 'Миколайович', TO_DATE('01-01-1999', 'DD-MM-YYYY'), 'M', 0);

INSERT INTO BSO_STUDENTS (id, last_name, first_name, middle_name, birth_date, gender, military_service)
VALUES (2, 'Петрова', 'Марія', 'Вікторівна', TO_DATE('01-01-2000', 'DD-MM-YYYY'), 'F', 1);

INSERT INTO BSO_STUDENTS (id, last_name, first_name, middle_name, birth_date, gender, military_service)
VALUES (3, 'Сидорчук', 'Ігор', 'Олегович', TO_DATE('01-01-2001', 'DD-MM-YYYY'), 'M', 1);

DECLARE
    TYPE student_list IS TABLE OF BSO_STUDENTS%ROWTYPE INDEX BY PLS_INTEGER;
    students student_list;
    male_stats FIO_STATISTICS%ROWTYPE;
    female_stats FIO_STATISTICS%ROWTYPE;
BEGIN
    -- Получаем список военнообязанных студентов из таблицы FIO_STUDENTS
    SELECT * BULK COLLECT INTO students FROM BSO_STUDENTS WHERE military_service = 1;
    
    -- Заполняем таблицу FIO_MilitaryService из полученного списка студентов
    FOR i IN 1..students.COUNT LOOP
        INSERT INTO FIO_MilitaryService (student_id, last_name, first_name, middle_name, birth_date, gender, military_service)
        VALUES (students(i).id, students(i).last_name, students(i).first_name, students(i).middle_name, students(i).birth_date, students(i).gender, 1);
    END LOOP;
    
    -- Вычисляем статистики для мужчин
    SELECT MAX(TRUNC(MONTHS_BETWEEN(SYSDATE, birth_date) / 12)), 
           MIN(TRUNC(MONTHS_BETWEEN(SYSDATE, birth_date) / 12)), 
           AVG(TRUNC(MONTHS_BETWEEN(SYSDATE, birth_date) / 12)), 
           COUNT(*) 
    INTO male_stats.max_age, male_stats.min_age, male_stats.avg_age, male_stats.num_people 
    FROM BSO_STUDENTS 
    WHERE gender = 'M' AND military_service = 1;
    male_stats.gender := 'M';
    
    -- Вычисляем статистики для женщин
    SELECT MAX(TRUNC(MONTHS_BETWEEN(SYSDATE, birth_date) / 12)), 
           MIN(TRUNC(MONTHS_BETWEEN(SYSDATE, birth_date) / 12)), 
           AVG(TRUNC(MONTHS_BETWEEN(SYSDATE, birth_date) / 12)), 
           COUNT(*) 
    INTO female_stats.max_age, female_stats.min_age, female_stats.avg_age, female_stats.num_people 
    FROM BSO_STUDENTS 
    WHERE gender = 'F' AND military_service = 1;
    female_stats.gender := 'F';
    
    -- Вставляем вычисленные статистики в таблицу FIO_STATISTICS
    INSERT INTO FIO_STATISTICS (gender, max_age, min_age, avg_age, num_people)
    VALUES (male_stats.gender, male_stats.max_age, male_stats.min_age, male_stats.avg_age, male_stats.num_people);
    INSERT INTO FIO_STATISTICS (gender, max_age, min_age, avg_age, num_people)
    VALUES (female_stats.gender, female_stats.max_age, female_stats.min_age, female_stats.avg_age, female_stats.num_people);
END;
SELECT * FROM FIO_STATISTICS;