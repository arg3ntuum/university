package com.company;

public class LowArray {

    private long[] a; // Посилання на масив a

    public LowArray(int size) { // Конструктор
        a = new long[size]; // Створення масиву
    }



    public void setElem(int index, long value) { // Запис елемента
        a[index] = value;
    }

    public long getElem(int index) { // Читання елемента
        return a[index];
    }

} // Кінець класу LowArray