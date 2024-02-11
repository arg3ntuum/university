/*1. Используя, внешнее объединение таблицы students и marks и операторы работы с множествами (MINUS) 
выведите список студентов имеющих задолженности, то есть «не явившихся на экзамен» и имеющих отметку 0.*/
INSERT INTO SRO_STUDENTS(st_record_book, st_name, st_patronymic, st_surname, st_birthday, st_sex, st_living_place, st_group, st_grant)
    VALUES (1, 'Vladimir', 'Sergeevich', 'Malko', '1-10-2004', 'M', 'Flat', 'KI-21-1', 12);
INSERT INTO SRO_MARKS(m_student_id, m_subject_id, m_mark) VALUES (1, 9, 0);
commit;

SELECT * FROM SRO_STUDENTS
FULL OUTER JOIN SRO_MARKS
ON SRO_STUDENTS.st_record_book = SRO_MARKS.m_student_id
MINUS 
SELECT * FROM SRO_STUDENTS
FULL OUTER JOIN SRO_MARKS
ON SRO_STUDENTS.st_record_book = SRO_MARKS.m_student_id
WHERE m_mark != 0 or m_mark IS NULL or st_name IS NULL;

/*2. Аналогично поиску студентов, не явившихся на экзамены,
найдите только тех, которые пропустили экзамены кафедры иностранных языком.*/
INSERT INTO SRO_STUDENTS(st_record_book, st_name, st_patronymic, st_surname, st_birthday, st_sex, st_living_place, st_group, st_grant)
    VALUES (2, 'Vladimir', 'Sergeevich', 'Malko', '1-10-2004', 'M', 'Flat', 'KI-21-1', 12);
INSERT INTO SRO_MARKS(m_student_id, m_subject_id, m_mark) VALUES (2, 5, 0);
INSERT INTO SRO_subjects(sb_id, sb_subject, sb_teacher_id, sb_load) VALUES (2, 'Math', 45, 2);
INSERT INTO SRO_TEACHERS (t_id, t_name, t_patronymic, t_surname, t_birthday, t_sex, t_living_place, t_chair_id, t_manager_id, t_position, t_salary)
    VALUES (210, 'ANNA', 'ALEXSANDROVNA', 'DLANKO', '6-3-1990', 'W', 'Flat', 1, 22, 'ZamKafedri', 2000);
INSERT INTO SRO_chairs(ch_chair_id, ch_name, ch_manager_id, ch_phone) VALUES (3, 'Lang eng', 5, '05334556');
commit;

--добавим несуществующую пару
INSERT INTO SRO_STUDENTS(st_record_book, st_name, st_patronymic, st_surname, st_birthday, st_sex, st_living_place, st_group, st_grant)
    VALUES (3, 'Vladimir', 'Sergeevich', 'Malko', '1-10-2004', 'M', 'Flat', 'KI-21-1', 12);
INSERT INTO SRO_MARKS(m_student_id, m_subject_id, m_mark) VALUES (1, 10, 0);
commit;

SELECT * FROM SRO_STUDENTS
FULL OUTER JOIN SRO_MARKS
ON SRO_STUDENTS.st_record_book = SRO_MARKS.m_student_id
WHERE m_subject_id
IN (SELECT sb_id FROM SRO_subjects WHERE sb_teacher_id IN 
    (SELECT t_id FROM SRO_teachers WHERE t_chair_id IN 
        (SELECT ch_chair_id FROM SRO_chairs WHERE ch_name LIKE '%Lang%')
    )
)
MINUS 
SELECT * FROM SRO_STUDENTS
FULL OUTER JOIN SRO_MARKS
ON SRO_STUDENTS.st_record_book = SRO_MARKS.m_student_id
WHERE (m_mark != 0 or (m_mark IS NULL or st_name IS NULL))
AND m_subject_id IN (SELECT sb_id FROM SRO_subjects WHERE sb_teacher_id IN 
    (SELECT t_id FROM SRO_teachers WHERE t_chair_id IN 
        (SELECT ch_chair_id FROM SRO_chairs WHERE ch_name LIKE '%Lang%')
    )
);

/*3. Создайте представление FIO_view_students_lp_dnieprop,
в которое отбираются только те студенты, которые живут в городе Днепропетровск.*/
INSERT INTO SRO_STUDENTS(st_record_book, st_name, st_patronymic, st_surname, st_birthday, st_sex, st_living_place, st_group, st_grant)
    VALUES (13, 'Анна', 'Витальевич', 'Ахметова', '1-10-2004', 'M', 'Днепр', 'KI-21-1', 12);
INSERT INTO SRO_STUDENTS(st_record_book, st_name, st_patronymic, st_surname, st_birthday, st_sex, st_living_place, st_group, st_grant)
    VALUES (14, 'Евгений', 'Юрьевич', 'Фесенко', '1-10-2005', 'M', 'Днепр', 'KI-21-1', 12);

CREATE VIEW SRO_view_students_lp_dnieprop AS
SELECT *
FROM SRO_STUDENTS
WHERE st_living_place LIKE 'Днепр';

DROP VIEW SRO_view_students_lp_dnieprop;

SELECT * FROM SRO_view_students_lp_dnieprop;

/*4. Создайте представление FIO_view_students_count_age, которое включает названия групп, 
количество студентов в каждой группе и средний возраст.*/
CREATE VIEW SRO_view_students_count_age AS 
SELECT 
 DISTINCT st_group as vs_groups,
 COUNT(*) AS vs_count_students,
 SUM(ROUND((SYSDATE - TO_DATE(st_birthday))/365, 1))/COUNT(*) AS vs_avarage_age
FROM SRO_STUDENTS
GROUP BY st_group;

SELECT * FROM SRO_view_students_count_age;

DROP VIEW SRO_view_students_count_age;

SELECT COUNT(DISTINCT st_group) AS SA FROM SRO_STUDENTS;--ПОЛУЧИЛИ КОЛ-ВО СТОЛБЦОВ РАЗНЫХ

/*5. Создайте агрегированное представление FIO_view_chair_count на основе таблиц chairs и teachers, 
которое включает название кафедры (chairs.ch_name), телефон (chairs.ch_phone) и количество преподавателей (teachers.t_chair_id).*/

CREATE VIEW SRO_view_chair_count AS 
SELECT 
 ch.ch_name AS vsc_name_chair,
 ch.ch_phone AS vsc_phone,
 (SELECT COUNT(*) FROM sro_teachers WHERE t_chair_id IN (SELECT ch_chair_id FROM sro_chairs)) AS vsc_count_teachers
FROM sro_chairs ch, sro_teachers t;

SELECT * FROM SRO_view_chair_count;
SELECT * FROM SRO_chairs;

DROP VIEW SRO_view_chair_count;
