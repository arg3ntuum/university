DROP TABLE FIO_MARKS;
DROP TABLE FIO_STUDENTS;

SET SERVEROUTPUT ON;

CREATE TABLE FIO_STUDENTS (
   student_id   NUMBER(10) PRIMARY KEY,
   first_name   VARCHAR2(50),
   last_name    VARCHAR2(50),
   st_grant     VARCHAR2(20)
);

CREATE TABLE FIO_MARKS (
   mark_id    NUMBER(10) PRIMARY KEY,
   student_id NUMBER(10),
   mark       NUMBER(2),
   FOREIGN KEY (student_id) REFERENCES FIO_STUDENTS(student_id)
);

-- заполнение таблицы FIO_STUDENTS
INSERT INTO FIO_STUDENTS (student_id, first_name, last_name, st_grant)
VALUES (1, 'Иван', 'Иванов', NULL);

INSERT INTO FIO_STUDENTS (student_id, first_name, last_name, st_grant)
VALUES (2, 'Петр', 'Петров', NULL);

INSERT INTO FIO_STUDENTS (student_id, first_name, last_name, st_grant)
VALUES (3, 'Сидор', 'Сидоров', NULL);

-- заполнение таблицы FIO_MARKS
INSERT INTO FIO_MARKS (mark_id, student_id, mark)
VALUES (1, 1, 4);

INSERT INTO FIO_MARKS (mark_id, student_id, mark)
VALUES (2, 1, 5);

INSERT INTO FIO_MARKS (mark_id, student_id, mark)
VALUES (3, 2, 3);

INSERT INTO FIO_MARKS (mark_id, student_id, mark)
VALUES (4, 2, 4);

INSERT INTO FIO_MARKS (mark_id, student_id, mark)
VALUES (5, 3, 2);

INSERT INTO FIO_MARKS (mark_id, student_id, mark)
VALUES (6, 3, 3);

DECLARE
-- объявление курсора для расчета размера стипендии
CURSOR c_marks IS
SELECT student_id, AVG(mark) as avg_mark
FROM FIO_MARKS
GROUP BY student_id;

-- объявление переменных для хранения данных о студенте и его стипендии
v_student_id FIO_STUDENTS.student_id%TYPE;
v_stipend FIO_STUDENTS.st_grant%TYPE;

-- объявление курсора для вывода списка студентов и размеров их стипендии
CURSOR c_students IS
SELECT last_name, st_grant
FROM FIO_STUDENTS;

BEGIN
-- открытие курсора для расчета размера стипендии
OPEN c_marks;

-- чтение первой строки из курсора
FETCH c_marks INTO v_student_id, v_stipend;

-- цикл по строкам курсора
WHILE c_marks%FOUND LOOP
-- обновление поля st_grant в таблице FIO_STUDENTS
UPDATE FIO_STUDENTS
SET st_grant = CASE
WHEN v_stipend >= 4.5 THEN 'Высокая'
WHEN v_stipend >= 3.5 THEN 'Средняя'
WHEN v_stipend >= 2.5 THEN 'Низкая'
ELSE 'Нет стипендии'
END
WHERE student_id = v_student_id;

  -- чтение следующей строки из курсора
  FETCH c_marks INTO v_student_id, v_stipend;
END LOOP;

-- закрытие курсора для расчета размера стипендии
CLOSE c_marks;

-- вывод списка студентов и размеров их стипендии
FOR student IN c_students LOOP
DBMS_OUTPUT.PUT_LINE(student.last_name || ' - ' || student.st_grant);
END LOOP;
END;
/