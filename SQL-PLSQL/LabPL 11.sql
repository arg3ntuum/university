DROP TABLE FIO_GRAFT;

-- Создание таблицы FIO_GRAFT
CREATE TABLE FIO_GRAFT (
  id NUMBER,
  last_name VARCHAR2(50),
  grafts SYS.ODCIVARCHAR2LIST
);

-- Заполнение таблицы FIO_GRAFT данными
INSERT INTO FIO_GRAFT (id, last_name, grafts) VALUES (
  1,
  'Ivanov',
  SYS.ODCIVARCHAR2LIST('2021-01-01', '2022-02-02')
);
INSERT INTO FIO_GRAFT (id, last_name, grafts) VALUES (
  2,
  'Petrov',
  SYS.ODCIVARCHAR2LIST('2021-03-03', '2022-04-04', '2023-05-05')
);
INSERT INTO FIO_GRAFT (id, last_name, grafts) VALUES (
  3,
  'Sidorov',
  SYS.ODCIVARCHAR2LIST('2020-01-01', '2022-04-04', '2023-05-05')
);

-- Вывод записей из таблицы FIO_GRAFT вместе с прививками
DECLARE
  v_grafts SYS.ODCIVARCHAR2LIST;
BEGIN
  FOR rec IN (SELECT id, last_name, grafts FROM FIO_GRAFT) LOOP
    v_grafts := rec.grafts;
    DBMS_OUTPUT.PUT_LINE('ID: ' || rec.id || ', Фамилия: ' || rec.last_name);
    IF v_grafts IS NOT NULL THEN
      FOR i IN v_grafts.FIRST .. v_grafts.LAST LOOP
        DBMS_OUTPUT.PUT_LINE('   Прививка: ' || v_grafts(i));
      END LOOP;
    END IF;
  END LOOP;
END;
/

/*
Для корректного вывода на экран используется функция DBMS_OUTPUT.PUT_LINE(), 
поэтому перед выполнением программы нужно выполнить команду SET SERVEROUTPUT ON.
*/