/*Students*//*Students*//*Students*//*Students*/
CREATE TABLE SRO_students
(
st_record_book NUMBER(6),
st_name VARCHAR2(20),
st_patronymic VARCHAR2(20),
st_surname VARCHAR2(20),
st_birthday DATE,
st_sex CHAR(1),
st_living_place VARCHAR2(20),
st_group VARCHAR2(7)
);

SELECT 
    st_record_book AS номер_зачётки,
    st_name AS имя_студента,
    st_patronymic AS отчество,
    st_surname AS фамилия,
    st_birthday AS дата_рождения,
    st_sex AS пол,
    st_living_place AS место_жительства,
    st_group AS группа_факультета
FROM SRO_STUDENTS;
/*Students*//*Students*//*Students*//*Students*/

/*Subjects*//*Subjects*//*Subjects*//*Subjects*/
CREATE TABLE SRO_subjects
(
sb_id NUMBER(3),
sb_subject VARCHAR2(40),
sb_teacher_id NUMBER(4),
sb_load NUMBER(3) DEFAULT 0
);

SELECT 
    sb_id AS идентификатор_предмета,
    sb_subject AS название_предметаа,
    sb_teacher_id AS идентификатор_преподавателя,
    sb_load AS общее_количество_часов
FROM SRO_subjects;
/*Subjects*//*Subjects*//*Subjects*//*Subjects*/

/*Teacher*//*Teacher*//*Teacher*//*Teacher*/
CREATE TABLE SRO_teachers
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

SELECT 
    t_id AS номер_зачётки,
    t_name AS имя_студента,
    t_patronymic AS отчество,
    t_surname AS фамилия,
    t_birthday AS дата_рождения,
    t_sex AS пол,
    t_living_place AS место_жительства,
    t_chair_id AS идентификатор_кафедры,
    t_manager_idAS идентификатор_начальника,
    t_position AS должность,
    t_salary AS зарплата
FROM SRO_teachers;
/*Teacher*//*Teacher*//*Teacher*//*Teacher*/

/*Chairs*//*Chairs*//*Chairs*//*Chairs*/
CREATE TABLE SRO_chairs
(
ch_chair_id NUMBER(2),
ch_name VARCHAR2(20) NOT NULL,
ch_manager_id NUMBER(4),
ch_phone VARCHAR2(8)
);

SELECT 
    ch_chair_id AS номер_кафедры,
    ch_name AS название_кафедры,
    ch_manager_id AS заведующий_кафедры,
    ch_phone AS телефон
FROM SRO_chairs;
/*Chairs*//*Chairs*//*Chairs*//*Chairs*/

/*Marks*//*Marks*//*Marks*//*Marks*/
CREATE TABLE SRO_marks(
    m_student_id NUMBER(6),
    m_subject_id NUMBER(3),
    m_mark NUMBER(1)
);

SELECT 
    m_student_id AS идентификатор_студента,
    m_subject_id AS идентификатор_предмета,
    m_mark AS отметка
FROM SRO_marks;
/*Marks*//*Marks*//*Marks*//*Marks*/

/*DROP ALL TABLES*//*DROP ALL TABLES*/
DROP TABLE SRO_marks; 
DROP TABLE SRO_chairs; 
DROP TABLE SRO_teachers; 
DROP TABLE SRO_subjects; 
DROP TABLE SRO_STUDENTS; 
/*DROP ALL TABLES*//*DROP ALL TABLES*/