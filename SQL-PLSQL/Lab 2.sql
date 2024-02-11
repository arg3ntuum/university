/*Create table ANOTHER*/
CREATE TABLE ANOTHER_SRO_STUDENTS(
st_record_book NUMBER(6),
st_name VARCHAR2(20),
st_patronymic VARCHAR2(20),
st_surname VARCHAR2(20),
st_birthday DATE,
st_sex CHAR(1),
st_living_place VARCHAR2(20),
st_group VARCHAR2(7),
st_grant NUMBER(4) DEFAULT 12
);
CREATE TABLE ANOTHER_SRO_subjects
(
sb_id NUMBER(3),
sb_subject VARCHAR2(40),
sb_teacher_id NUMBER(4),
sb_load NUMBER(3) DEFAULT 0
);
CREATE TABLE ANOTHER_SRO_teachers
(t_id NUMBER(4),
t_name VARCHAR2(20),
t_patronymic VARCHAR2(20),
t_surname VARCHAR2(20),
t_birthday DATE,
t_sex CHAR(1),
t_living_place VARCHAR2(20),
t_chair_id NUMBER(2),
t_manager_id NUMBER(4),
t_position VARCHAR2(20) NOT NULL,
t_salary NUMBER(4)
);
CREATE TABLE ANOTHER_SRO_chairs
(
ch_chair_id NUMBER(2),
ch_name VARCHAR2(20) NOT NULL,
ch_manager_id NUMBER(4),
ch_phone VARCHAR2(8)
);
CREATE TABLE ANOTHER_SRO_marks(
    m_student_id NUMBER(6),
    m_subject_id NUMBER(3),
    m_mark NUMBER(1)
);

/*INSERT DATA - Download to table info*/
INSERT INTO ANOTHER_SRO_STUDENTS(st_record_book, st_name, st_patronymic, st_surname, st_birthday, st_sex, st_living_place, st_group, st_grant)
    VALUES (12, 'Vladislav', 'Oleghovish', 'Velikov', '03-04-2004', 'M', 'Flat', 'RI-97-1', 12);
INSERT INTO ANOTHER_SRO_STUDENTS(st_record_book, st_name, st_patronymic, st_surname, st_birthday, st_sex, st_living_place, st_group, st_grant) 
    VALUES (23, 'Andrew', 'Alekseevich', 'Frunko', '11-11-2003', 'M', 'Flat', 'RI-97-1', 15);
INSERT INTO ANOTHER_SRO_STUDENTS(st_record_book, st_name, st_patronymic, st_surname, st_birthday, st_sex, st_living_place, st_group, st_grant) 
    VALUES (5, 'Anastasya', 'Degenetativna', 'Zhizn', '5-04-2004', 'W', 'House', 'RI-97-1', 19);
INSERT INTO ANOTHER_SRO_STUDENTS(st_record_book, st_name, st_patronymic, st_surname, st_birthday, st_sex, st_living_place, st_group, st_grant) 
    VALUES (8, 'Rostislav', 'Oleksandrovich', 'Shvec', '14-12-2003', 'M', 'House', 'RI-97-1', 2);
INSERT INTO ANOTHER_SRO_STUDENTS(st_record_book, st_name, st_patronymic, st_surname, st_birthday, st_sex, st_living_place, st_group, st_grant) 
    VALUES (8, 'Dmirty', 'Konstantinovich', 'Antonenko', '3-06-2004', 'M',  'Flat', 'KI-21-2', 0);
    
INSERT INTO ANOTHER_SRO_subjects(sb_id, sb_subject, sb_teacher_id, sb_load) VALUES (2, 'Math', 45, 2);
INSERT INTO ANOTHER_SRO_subjects(sb_id, sb_subject, sb_teacher_id, sb_load) VALUES (5, 'English', 99, 7);
INSERT INTO ANOTHER_SRO_subjects(sb_id, sb_subject, sb_teacher_id, sb_load) VALUES (9, 'Programming', 12, 45);

INSERT INTO ANOTHER_SRO_teachers(t_id, t_name, t_patronymic, t_surname, t_birthday, t_sex, t_living_place, t_chair_id, t_manager_id, t_position, t_salary)
    VALUES (312, 'Lubov', 'Ivanovna', 'Shvec', '6-3-1990', 'W', 'Flat', 1, 22, 'ZamKafedri', 2000);
INSERT INTO ANOTHER_SRO_teachers(t_id, t_name, t_patronymic, t_surname, t_birthday, t_sex, t_living_place, t_chair_id, t_manager_id, t_position, t_salary)
    VALUES (12, 'Roza', 'Vladimirovna', 'Emec', '6-3-1981', 'W', 'Flat', 3, 22, 'GlavKafedri', 2000);
    
INSERT INTO ANOTHER_SRO_chairs(ch_chair_id, ch_name, ch_manager_id, ch_phone) VALUES (1, 'Lang ru', 5, '05334553');
INSERT INTO ANOTHER_SRO_chairs(ch_chair_id, ch_name, ch_manager_id, ch_phone) VALUES (3, 'Lang eng', 5, '05334556');

INSERT INTO ANOTHER_SRO_marks(m_student_id, m_subject_id, m_mark) VALUES (3234, 33, 5);
INSERT INTO ANOTHER_SRO_marks(m_student_id, m_subject_id, m_mark) VALUES (24233, 93, 5);
INSERT INTO ANOTHER_SRO_marks(m_student_id, m_subject_id, m_mark) VALUES (3331, 233, 2);
commit;

/*VIEW INFO TABLES*/
SELECT * FROM another_sro_students;
SELECT * FROM another_sro_subjects;
SELECT * FROM another_sro_teachers;
SELECT * FROM another_sro_chairs;
SELECT * FROM another_sro_marks;

/*DELETE ANOTHER TABLES*/
DROP TABLE another_sro_students; 
DROP TABLE another_sro_subjects; 
DROP TABLE another_sro_teachers; 
DROP TABLE another_sro_chairs; 
DROP TABLE another_sro_marks; 

/*Задание 1 ~~~~ INSERT INFO FROM 1 TABLE TO 2*/
INSERT INTO SRO_marks(m_student_id, m_subject_id, m_mark)
    SELECT m_student_id, m_subject_id, m_mark FROM ANOTHER_SRO_marks;
INSERT INTO SRO_chairs(ch_chair_id, ch_name, ch_manager_id, ch_phone) 
    SELECT ch_chair_id, ch_name, ch_manager_id, ch_phone FROM ANOTHER_SRO_chairs;
INSERT INTO SRO_teachers(t_id, t_name, t_patronymic, t_surname, t_birthday, t_sex, t_living_place, t_chair_id, t_manager_id, t_position, t_salary) 
    SELECT t_id, t_name, t_patronymic, t_surname, t_birthday, t_sex, t_living_place, t_chair_id, t_manager_id, t_position, t_salary FROM another_sro_teachers;
INSERT INTO SRO_subjects(sb_id, sb_subject, sb_teacher_id, sb_load) 
    SELECT sb_id, sb_subject, sb_teacher_id, sb_load FROM another_sro_subjects;
INSERT INTO SRO_STUDENTS(st_record_book, st_name, st_patronymic, st_surname, st_birthday, st_sex, st_living_place, st_group, st_grant) 
    SELECT st_record_book, st_name, st_patronymic, st_surname, st_birthday, st_sex, st_living_place, st_group, st_grant FROM another_sro_students;

/*Задание 2 ~~~~ INSERT INFO ABOUT ME */
INSERT INTO SRO_STUDENTS(st_record_book, st_name, st_patronymic, st_surname, st_birthday, st_sex, st_living_place, st_group, st_grant)
    VALUES (19, 'Rostyslav', 'Oleksandrovich', 'Sheyko', '4-12-2003', 'M', 'Flat', 'KI-21-2', 12);
commit;

/*Задание 3 ~~~~ Выведите список студентов группы RI-97-1 в алфавитном порядке. */
SELECT 
* 
FROM sro_students
WHERE st_group = 'RI-97-1'
ORDER BY st_name;

/*Задание 4 ~~~~ Выведите информацию о студентах в следующем виде - номер группы, фамилия, инициалы.
Отсортируйте в таком же порядке и выведите фамилии заглавными буквами.*/
SELECT 
ST_GROUP AS номер_группы, 
UPPER (st_surname) AS фамилия,
CONCAT(
    CONCAT (SUBSTR(ST_NAME, 0, 1), '. '),
    CONCAT (SUBSTR(st_patronymic, 0, 1), '. '))
AS инициалы
FROM SRO_STUDENTS
ORDER BY st_surname;

/*Задание 5 ~~~~ Определите самого младшего студента в каждой группе.*/
SELECT 
    *
FROM (
SELECT * FROM SRO_STUDENTS 
WHERE st_group = 'RI-97-1'
ORDER BY st_birthday
)
WHERE ROWNUM <= 1
UNION 
SELECT 
    *
FROM (
SELECT * FROM SRO_STUDENTS 
WHERE st_group = 'KI-21-2' 
ORDER BY st_birthday
)
WHERE ROWNUM <= 1;

/*Задание 6 ~~~~ Определите самую длинную фамилию среди студентов на потоке.*/
SELECT * 
FROM SRO_STUDENTS 
WHERE LENGTH(ST_SURNAME) = (SELECT max(LENGTH(ST_SURNAME))
FROM SRO_STUDENTS);