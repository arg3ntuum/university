/*1. Определите самую длинную фамилию среди студентов в группе.*/
SELECT * 
FROM SRO_STUDENTS 
WHERE LENGTH(ST_SURNAME) = (SELECT max(LENGTH(ST_SURNAME))
FROM SRO_STUDENTS 
WHERE st_group = 'RI-97-1' );

/*Необходимо вывести студентов сдавших экзамены по двум иностранным языкам на «отлично». Предлагаем следующий алгоритм:

a. Шаг 1. Определим номер кафедры иностранного языка (ch_chair_id) из таблицы chairs.
b. Шаг 2. Необходимо получить идентификаторы всех преподавателей кафедры (t_id) из таблицы teachers.
c. Шаг 3. Используя многострочный подзапрос, определим список идентификаторов предметов (sb_id) из таблицы subjects, которые читаются этими преподавателями.
d. Шаг 4. Из таблицы marks определим студентов (m_student_id) сдавших предметы на пять.
e. Шаг 5. И наконец, из таблицы students найдём группу (st_group), фамилию (st_surname) и имя (st_name) этих студентов.
*/

SELECT ch_chair_id FROM SRO_chairs WHERE ch_name LIKE '%Lang%';--шаг 1

SELECT t_id FROM sro_teachers WHERE t_chair_id IN (SELECT ch_chair_id FROM SRO_chairs WHERE ch_name LIKE '%Lang%');--шаг 2

SELECT sb_id FROM sro_subjects WHERE sb_teacher_id IN (SELECT t_id FROM sro_teachers WHERE t_chair_id IN (SELECT ch_chair_id FROM SRO_chairs WHERE ch_name LIKE '%Lang%'));--шаг 3

SELECT m_student_id FROM sro_marks WHERE m_subject_id IN (
    SELECT sb_id FROM sro_subjects WHERE sb_teacher_id IN (
        SELECT t_id FROM sro_teachers WHERE t_chair_id IN (
            SELECT ch_chair_id FROM SRO_chairs WHERE ch_name LIKE '%Lang%'
        )
    )
);--шаг 4

SELECT st_group, st_surname, st_name FROM SRO_STUDENTS WHERE st_record_book IN (SELECT m_student_id FROM sro_marks WHERE m_subject_id IN (
    SELECT sb_id FROM sro_subjects WHERE sb_teacher_id IN (
        SELECT t_id FROM sro_teachers WHERE t_chair_id IN (
            SELECT ch_chair_id FROM SRO_chairs WHERE ch_name LIKE '%Lang%'
        )
    )
)) ;