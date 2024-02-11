DROP TABLE groups;
DROP TYPE lecture_type;
DROP PROCEDURE print_lectures;
-- Создание таблицы
CREATE TABLE groups (
  group_id NUMBER PRIMARY KEY,
  department VARCHAR2(50),
  students_count NUMBER,
  lectures lectures_type
);

-- Определение типа lectures
CREATE TYPE lecture_type AS OBJECT (
  subject VARCHAR2(50),
  lecturer VARCHAR2(50),
  read_hours NUMBER
);
CREATE TYPE lectures_type AS VARRAY(10) OF lecture_type;

-- Вставка данных для первой группы
INSERT INTO groups (group_id, department, students_count, lectures) VALUES (
  1,
  'IT',
  30,
  lectures_type(
    lecture_type('Introduction to programming', 'Ivanov', 40),
    lecture_type('Data structures and algorithms', 'Petrov', 60)
  )
);

-- Процедура для вывода данных о лекциях в каждой группе
CREATE OR REPLACE PROCEDURE print_lectures IS
  cur SYS_REFCURSOR;
  group_id NUMBER;
  department VARCHAR2(50);
  students_count NUMBER;
  l_lecture lecture_type;
BEGIN
  OPEN cur FOR
    SELECT group_id, department, students_count, l_lecture
    FROM groups;
  LOOP
    FETCH cur INTO group_id, department, students_count, l_lecture;
    EXIT WHEN cur%NOTFOUND;
    DBMS_OUTPUT.PUT_LINE('Group ID: ' || group_id);
    DBMS_OUTPUT.PUT_LINE('Department: ' || department);
    DBMS_OUTPUT.PUT_LINE('Students Count: ' || students_count);
    IF l_lecture IS NULL THEN
      DBMS_OUTPUT.PUT_LINE('No lectures for this group');
    ELSE
      FOR i IN 1..l_lecture.COUNT LOOP
        DBMS_OUTPUT.PUT_LINE('Lecture ' || i || ':');
        DBMS_OUTPUT.PUT_LINE('  Subject: ' || l_lecture(i).subject);
        DBMS_OUTPUT.PUT_LINE('  Lecturer: ' || l_lecture(i).lecturer);
        DBMS_OUTPUT.PUT_LINE('  Read Hours: ' || l_lecture(i).read_hours);
      END LOOP;
    END IF;
    DBMS_OUTPUT.PUT_LINE('---------------------');
  END LOOP;
  CLOSE cur;
END;

-- Вставка данных для первой группы
INSERT INTO groups (group_id, department, students_count, lectures) VALUES (
  1,
  'IT',
  30,
  lectures_type(
    lecture_type('Introduction to programming', 'Ivanov', 40),
    lecture_type('Data structures and algorithms', 'Petrov', 60)
  )
);

-- Вставка данных для второй группы
DECLARE
  l_lectures lectures_type;
BEGIN
  l_lectures := lectures_type();
  l_lectures.EXTEND(2);
  l_lectures(1) := lecture_type('Database design', 'Sidorov', 50);
  l_lectures(2) := lecture_type('Operating systems', 'Kozlov', 70);
  INSERT INTO groups (group_id, department, students_count, lectures) VALUES (
    2,
    'Math',
    25,
    l_lectures
  );
END;

-- Изменение данных с помощью оператора THE
DECLARE
  l_lectures lectures_type;
BEGIN
  SELECT lectures INTO l_lectures FROM groups WHERE group_id = 2;
  l_lectures(l_lectures.COUNT).lecturer := 'Smirnov';
  UPDATE groups SET lectures = THE(l_lectures) WHERE group_id = 2;
END;

-- Удаление данных о лекциях первой группы
UPDATE groups SET lectures = NULL WHERE group_id = 1;

-- Проверка, является ли lectures NULL-таблицей
IF (SELECT lectures FROM groups WHERE group_id = 1) IS NULL THEN
  DBMS_OUTPUT.PUT_LINE('Вложенная таблица пуста (NULL-таблица)');
ELSE
  DBMS_OUTPUT.PUT_LINE('Вложенная таблица не пуста');
END IF;