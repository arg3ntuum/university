/*1. Необходимо создать ограничение FIO_marks_mark для поля m_mark таблицы FIO_marks,
которое запретит ввод других оценок кроме 1,2,3,4,5 и 0 (0 – указывает на несданный экзамен).*/
CREATE TABLE SRO_marks_mark(
    
    m_student_id NUMBER(6),
    m_subject_id NUMBER(3),
    m_mark NUMBER(1) CHECK (m_mark >= 0 AND m_mark <= 5)
);

--test
INSERT INTO SRO_marks_mark (m_student_id, m_subject_id, m_mark) VALUES (3331, 5, 5);

SELECT * FROM SRO_marks_mark;

/*2. Создайте первичный ключ для таблицы FIO_students поле st_record_book.*/

CREATE TABLE SRO_students
(
st_record_book NUMBER(6),
st_name VARCHAR2(20),
st_patronymic VARCHAR2(20),
st_surname VARCHAR2(20),
st_birthday DATE,
st_sex CHAR(1),
st_living_place VARCHAR2(20),
st_group VARCHAR2(7),
st_grant NUMBER(4) DEFAULT 12,

PRIMARY KEY(st_record_book)
);

/*3. Создайте первичный ключ для таблицы FIO_subjects поле sb_id.*/

CREATE TABLE SRO_subjects
(
sb_id NUMBER(3),
sb_subject VARCHAR2(40),
sb_teacher_id NUMBER(4),
sb_load NUMBER(3) DEFAULT 0,

PRIMARY KEY(sb_id)
);

/*4. Создайте уникальный ключ для таблицы FIO_marks поля m_student_id и m_subjects_id.*/
CREATE TABLE SRO_marks(
    m_student_id NUMBER(6) UNIQUE,
    m_subject_id NUMBER(3) UNIQUE,
    m_mark NUMBER(1)
);

/*5. Создайте внешние ключи для таблицы FIO_marks на основании первичных ключей таблиц FIO_students и FIO_subjects.*/
CREATE TABLE SRO_marks(
    m_student_id NUMBER(6) UNIQUE,
    m_subject_id NUMBER(3) UNIQUE,
    m_mark NUMBER(1),
    
    FOREIGN KEY (m_student_id) REFERENCES SRO_students (st_record_book),
    FOREIGN KEY (m_subject_id) REFERENCES SRO_subjects (sb_id)
);

/*6. Удалите запись о студенте с номером зачётки 1 (st_record_book), учтите, 
что на основе этой записи созданы кортежи в таблице отметок (FIO_marks),
поэтому сначала необходимо удалить её зависимости (или переопределить свойства внешнего ключа).*/

INSERT INTO SRO_STUDENTS(st_record_book, st_name, st_patronymic, st_surname, st_birthday, st_sex, st_living_place, st_group, st_grant)
    VALUES (1, 'Vladimir', 'Sergeevich', 'Malko', '1-10-2004', 'M', 'Flat', 'KI-21-1', 12);
INSERT INTO SRO_marks(m_student_id, m_subject_id, m_mark) VALUES (1, 5, 5);
SELECT * FROM SRO_students;
SELECT * FROM SRO_marks;

UPDATE SRO_marks SET m_student_id = NULL WHERE m_student_id = 1;
DELETE FROM SRO_students WHERE st_record_book = 1;

/*7. Наиболее часто используемая таблица в нашей системе – FIO_student, 
поэтому необходимо создать для неё индекс FIO_students_name_index, 
включающий поля фамилии (st_surname), имени (st_name) и отчества (st_patronymic).*/ 

CREATE TABLE SRO_students
(
st_record_book NUMBER(6),
st_name VARCHAR2(20),
st_patronymic VARCHAR2(20),
st_surname VARCHAR2(20),

st_name VARCHAR2(20),
st_patronymic VARCHAR2(20),
st_surname VARCHAR2(20),
st_birthday DATE,
st_sex CHAR(1),
st_living_place VARCHAR2(20),
st_group VARCHAR2(7),
st_grant NUMBER(4) DEFAULT 12,

PRIMARY KEY(st_record_book)
);

CREATE BITMAP
INDEX SRO_students_name_index
ON SRO_students (st_name, st_patronymic, st_surname);

/*8. Для заполнения таблицы FIO_chairs создайте последовательность FIO_seq_chairs. 
На данный момент определено 4 кафедры, то есть последовательность должна начинать отсчёт с 5.*/
CREATE SEQUENCE SRO_seq_chairs
START WITH 5
INCREMENT BY 1;

CREATE TABLE SRO_chairs
(
ch_chair_id NUMBER(2) ,
ch_name VARCHAR2(20) NOT NULL,
ch_manager_id NUMBER(4),
ch_phone VARCHAR2(8)
);

INSERT INTO SRO_chairs (ch_chair_id, ch_name, ch_manager_id, ch_phone) VALUES (SRO_seq_chairs.NEXTVAL, 'Lang ua', 5, '05334553');

SELECT * FROM SRO_chairs;