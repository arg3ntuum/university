drop table fio_students;
drop table fio_marks;

CREATE TABLE fio_students (
id NUMBER PRIMARY KEY,
last_name VARCHAR2(50),
first_name VARCHAR2(50),
group_number VARCHAR2(10)
);

CREATE TABLE fio_marks (
id NUMBER PRIMARY KEY,
student_id NUMBER,
subject VARCHAR2(50),
mark NUMBER,
CONSTRAINT fk_student
FOREIGN KEY (student_id)
REFERENCES fio_students(id)
);

-- Заполнение таблицы fio_students
INSERT INTO fio_students (id, last_name, first_name, group_number)
VALUES (1, 'Иванов', 'Иван', '1');

INSERT INTO fio_students (id, last_name, first_name, group_number)
VALUES (2, 'Петров', 'Петр', '2');

INSERT INTO fio_students (id, last_name, first_name, group_number)
VALUES (3, 'Сидоров', 'Сидор', '1');

-- Заполнение таблицы fio_marks
INSERT INTO fio_marks (id, student_id, subject, mark)
VALUES (1, 1, 'Математика', 4);

INSERT INTO fio_marks (id, student_id, subject, mark)
VALUES (2, 1, 'Физика', 5);

INSERT INTO fio_marks (id, student_id, subject, mark)
VALUES (3, 2, 'Математика', 3);

INSERT INTO fio_marks (id, student_id, subject, mark)
VALUES (4, 2, 'Физика', 4);

INSERT INTO fio_marks (id, student_id, subject, mark)
VALUES (5, 3, 'Математика', 5);

INSERT INTO fio_marks (id, student_id, subject, mark)
VALUES (6, 3, 'Физика', 4);



DECLARE
-- Объявление переменных
cursor c_students is
select distinct student_id, last_name
from fio_marks join fio_students
on fio_marks.student_id = fio_students.id;

v_student_id fio_marks.student_id%type;
v_last_name fio_students.last_name%type;
v_average_mark number;

-- Исключительная ситуация, когда студент отличник
exc_student EXCEPTION;

BEGIN
-- Открытие курсора
open c_students;

-- Цикл по записям курсора
loop
-- Чтение следующей записи курсора
fetch c_students into v_student_id, v_last_name;

-- Выход из цикла, если больше нет записей
exit when c_students%notfound;

-- Вычисление среднего бала студента
select avg(mark) into v_average_mark
from fio_marks
where student_id = v_student_id;

-- Вывод на экран фамилии студента и его среднего бала
dbms_output.put_line(v_last_name || ': ' || v_average_mark);

-- Проверка на отличника
if v_average_mark = 5.0 then
  raise exc_student;
end if;
end loop;

-- Закрытие курсора
close c_students;
EXCEPTION
-- Обработка исключительной ситуации
when exc_student then
dbms_output.put_line(v_last_name || ': Отличник');
END;

/*
В данной программе используется курсор для выборки всех уникальных идентификаторов студентов и их фамилий из таблицы FIO_MARKS и FIO_STUDENTS. Затем для каждого студента вычисляется средний балл и выводится на экран с помощью процедуры DBMS_OUTPUT.PUT_LINE.

Если средний балл студента равен 5.0, то возникает исключительная ситуация exc_student. В блоке EXCEPTION данной ситуации соответствует вывод на экран фамилии студента с пометкой отличник.
*/