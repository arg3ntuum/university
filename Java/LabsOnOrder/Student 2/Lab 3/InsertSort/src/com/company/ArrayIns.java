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
        int N_comparison = 0, n_copy = 0;
        for(out = 1; out < nElems; out++) { // out - розділовий маркер
            long temp = a[out]; // Зкопіювати позначений елемент
            in = out; // Почати переміщення з out
            while(true) { // не знайдений менший елемент
                if(in > 0) {
                    N_comparison++;
                    if(a[in-1] >= temp) {
                        N_comparison++;
                        a[in] = a[in-1]; // Зрушити елемент вправо
                        --in; // Перейти на одну позицію вліво
                    }
                }
                if (!(in > 0 && a[in-1] >= temp)) {
                    break;
                }
            }
            n_copy++;
            a[in] = temp; // Вставити позначений елемент
        }
        System.out.println("Кількість копіюваннь: " + n_copy + "\tкількість порівнянь: " + N_comparison);
    }
    public long center() {
        long max = a[0], min= a[0];
        for(int j = 0; j<nElems; j++) {
            if (max < a[j])
                max = a[j];
            else if (min > a[j])
                min = a[j];
        }
        return (max + min)/2;
    }
    public long checkForReal(long center) {
        long mediana = 0;
        do {
            for(int j = 0; j<nElems; j++)
                if(a[j] == center)
                    mediana = a[j];
            if (mediana != 0)
                break;
            center++;
        } while (true);
        return mediana;
    }
    public long median() {
        return checkForReal(center());
    }
}
