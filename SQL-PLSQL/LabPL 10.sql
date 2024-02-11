DROP TABLE FIO_STUDENTS;

CREATE TABLE FIO_STUDENTS (
  id NUMBER PRIMARY KEY,
  name VARCHAR2(20),
  patronymic VARCHAR2(20),
  surname VARCHAR2(20),
  address VARCHAR2(50)
);

INSERT INTO FIO_STUDENTS VALUES (1, 'Иван', 'Иванович', 'Иванов', 'Москва');
INSERT INTO FIO_STUDENTS VALUES (2, 'Петр', 'Петрович', 'Петров', 'Санкт-Петербург');
INSERT INTO FIO_STUDENTS VALUES (3, 'Сидор', 'Сидорович', 'Сидоров', 'Новосибирск');

CREATE OR REPLACE TYPE FIO_NameObjTyp AS OBJECT (
    name VARCHAR2(20),
    patronymic VARCHAR2(20),
    surname VARCHAR2(20)
);

CREATE OR REPLACE TYPE FIO_PersonObjTyp AS OBJECT (
    id NUMBER,
    name FIO_NameObjTyp,
    address VARCHAR2(100)
);

CREATE OR REPLACE TYPE FIO_PersonObjTab AS TABLE OF FIO_PersonObjTyp;

DECLARE
  -- Объявляем переменные
  v_person_tab FIO_PersonObjTab := FIO_PersonObjTab();
  v_name FIO_NameObjTyp;
  v_address VARCHAR2(100);
BEGIN
  -- Заполняем объектную таблицу данными из таблицы FIO_STUDENTS
  FOR rec IN (SELECT id, name, patronymic, surname, address FROM FIO_STUDENTS)
  LOOP
    v_name := FIO_NameObjTyp(rec.name, rec.patronymic, rec.surname);
    v_address := rec.address;
    v_person_tab.extend;
    v_person_tab(v_person_tab.last) := FIO_PersonObjTyp(rec.id, v_name, v_address);
  END LOOP;

  -- Выводим на экран данные из таблицы FIO_PersonObjTab
  FOR i IN 1..v_person_tab.count LOOP
    DBMS_OUTPUT.PUT_LINE(v_person_tab(i).name.surname || ' ' || v_person_tab(i).name.name || ' ' || v_person_tab(i).address);
  END LOOP;
END;