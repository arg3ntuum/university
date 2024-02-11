package com.company;
import java.util.Scanner;
public class LowArray {
    Scanner in = new Scanner(System.in);
    int j; // Змінна циклу
    private long[] a; // Посилання на масив a

    public LowArray(int size) { // Конструктор

        a = new long[size]; // Створення масиву

    }

    public void setElem(int index, long value) { // Запис елемента

        a[index] = value;

    }

    public void FoundElement(int nElems) { // Запис елемента
        System.out.println("Впишіть значення в масив, яке ви хочите знайти: ");
        int searchKey = in.nextInt(); // Пошук елемента
        for (j = 0; j < nElems; j++) // Для кожного елемента
            if (getElem(j) == searchKey) // Значення знайдено?
                break;
        if (j == nElems) // Ні
            System.out.println("Значення " + searchKey + " не було знайдено.");
        else // Так
            System.out.println("Значення " + searchKey + " було знайдено.");
    }

    public int DeleteElement(int nElems) { // Запис елемента
        System.out.println("Впишіть значення в масив, яке ви хочите видалити: ");
        int choseKey = in.nextInt(); // Выбор елемента

        for (j = 0; j < nElems; j++) // Пошук елемента, що видаляється
            if (getElem(j) == choseKey)
                break;
        for (int k = j; k < nElems; k++) // Переміщення наступних елементів
            setElem(k, getElem(k + 1));
        nElems--;
        return nElems; // Зменшення розміру
    }

    public void MassiveOut(int nElems) { // Запис елемента
        System.out.print("Ваш масив:");
        for (j = 0; j < nElems; j++) // Вивід вмісту
            System.out.print(getElem(j) + " ");
        System.out.println("");
    }

    public void FoundMinMax(int nElems) { // Запис елемента
        long min = getElem(0), max = getElem(0);
        for (j = 0; j < nElems; j++) {
            if (min > getElem(j))
                min = getElem(j);
            else if (max < getElem(j))
                max = getElem(j);
        }
        System.out.println("Мінімальне значення: " + min + ", а максимальне значення :" + max);
    }

    public void FoundParniAndNeparni(int nElems) { // Запис елемента
        int par = 0, nepar = 0;
        for (j = 0; j < nElems; j++) {
            if (getElem(j) % 2 == 0)
                par++;
            else nepar++;
        }
        System.out.println("Кількість парних чисел: " + par + ", а кількость не парних : " + nepar);
    }

    public void Zamena(int nElems) {
        System.out.println("Для заміни усіх непарних значень на вказане значення уведіть його: ");
        int zamena = in.nextInt();
        for (j = 0; j < nElems; j++) {
            if (getElem(j) % 2 == 1)
                setElem(j, zamena);
            else;
        }
    }

    public long getElem(int index) { // Читання елемента

        return a[index];

    }

} // Кінець класу LowArray