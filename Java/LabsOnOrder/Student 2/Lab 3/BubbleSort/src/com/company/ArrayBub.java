package com.company;

public class ArrayBub { // Бульбашкове сортування
    private long[] a; // Посилання на масив a
    private int nElems; // Кількість елементів даних
    public ArrayBub(int max) { // Конструктор
        a = new long[max]; // Створення масиву
        nElems = 0; // Поки немає жодного елемента
    }
    public void insert(long value) { // Вставка елемента в масив
        a[nElems] = value; // Власне вставка
        nElems++; // Збільшення розміру
    }
    public void display() { // Вивід вмісту масиву
        for(int j = 0; j<nElems; j++) // Для кожного елемента
            System.out.print(a[j] + " "); // Вивід
        System.out.println("");
    }


    public void bubbleSort (int ChooseDIRECTION) {
        if (ChooseDIRECTION == 1) {
            int out, in;
            for (out = nElems - 1; out > 1; out--) // Зовнішній цикл
                for (in = 0; in < out; in++) // Внутрішній цикл (прямий)
                    if (a[in] > a[in + 1]) { // Порядок порушений?
                        long temp = a[in];
                        a[in] = a[in + 1];
                        a[in + 1] = temp; // Поміняти місцями
                    }
        }
        else {
            int out, in;
            for (out = nElems - 1; out > 1; out--) // Зовнішній цикл
                for (in = 0; in < out; in++) // Внутрішній цикл (прямий)
                    if (a[in] < a[in + 1]) { // Порядок порушений?
                        long temp = a[in + 1];
                        a[in + 1] = a[in];
                        a[in] = temp; // Поміняти місцями
                    }
        }
    }

} // Кінець класу ArrayBub