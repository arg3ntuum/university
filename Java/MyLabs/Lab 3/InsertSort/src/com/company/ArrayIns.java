package com.company;
public class ArrayIns {
    private long[] a; // Посилання на масив a
    private int nElems; // Кількість елементів даних
    public ArrayIns(int max) { // Конструктор
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
    public void insertionSort() {
        int in, out;
        int kolvo_poriv = 0, kolvo_kop = 0;
        for(out = 1; out < nElems; out++) { // out - розділовий маркер
            long temp = a[out]; // Зкопіювати позначений елемент
            in = out; // Почати переміщення з out
            while(true) { // не знайдений менший елемент
                if(in > 0) {
                    kolvo_poriv++;
                    if(a[in-1] >= temp) {
                        kolvo_poriv++;
                        a[in] = a[in-1]; // Зрушити елемент вправо
                        --in; // Перейти на одну позицію вліво
                    }
                }
                if (!(in > 0 && a[in-1] >= temp))
                {
                    break;
                }
            }
            kolvo_kop++;
            a[in] = temp; // Вставити позначений елемент
        }
        System.out.println("Количество копирований: " + kolvo_kop + "\tколичество сравнений: " + kolvo_poriv);
    }
    public long mediana () {
        long max = a[0], min= a[0], center, med = 0;
        for(int j = 0; j<nElems; j++)
        {
            //System.out.print(a[j] + " "); // Вивід
            if (max < a[j])
                max = a[j];
            else if (min > a[j])
                min = a[j];
        }// Для кожного елемента
        center = (max + min)/2;
        do {
            for(int j = 0; j<nElems; j++)
            {
                //System.out.print(a[j] + " "); // Вивід
                if(a[j] == center) {
                    med = a[j];
                }
            }
            if (med != 0)
                break;
            center++;
        } while (true);
        return med;
    }
}
