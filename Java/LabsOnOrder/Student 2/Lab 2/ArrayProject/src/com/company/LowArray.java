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

    public void PoiskElementa(int nElems) { // Запис елемента
        System.out.println("Если вам нужно что-то найти, впишите этот елемент прямо сейчас: ");
        int searchKey = in.nextInt(); // Пошук елемента
        for (j = 0; j < nElems; j++) // Для кожного елемента
            if (getElem(j) == searchKey) // Значення знайдено?
                break;
        if (j == nElems) // Ні
            System.out.println("То, что мы искали, а именно '" + searchKey + "' не было найдено.");
        else // Так
            System.out.println("То, что мы искали, а именно '" + searchKey + "' было найдено.");
    }

    public int UdalitElement(int nElems) { // Запис елемента
        System.out.println("Впишите елемент, что собираетесь удалить: ");
        int choseKey = in.nextInt(); // Выбор елемента

        for (j = 0; j < nElems; j++) // Пошук елемента, що видаляється
            if (getElem(j) == choseKey)
                break;
        for (int k = j; k < nElems; k++) // Переміщення наступних елементів
            setElem(k, getElem(k + 1));
        nElems--;
        return nElems; // Зменшення розміру
    }

    public void OutPut(int nElems) { // Запис елемента
        System.out.print("Вывод массива:");
        for (j = 0; j < nElems; j++) // Вивід вмісту
            System.out.print(getElem(j) + " ");
        System.out.println("");
    }

    public void MinAndMax(int nElems) { // Запис елемента
        long min = getElem(0), max = getElem(0);
        for (j = 0; j < nElems; j++) {
            if (min > getElem(j))
                min = getElem(j);
            else if (max < getElem(j))
                max = getElem(j);
        }
        System.out.println("Минимальное значение = " + min + ";\nМаксимальное значение = " + max+ ";");
    }

    public void ZnaytiParniTaNeparni(int nElems) { // Запис елемента
        int par = 0, nepar = 0;
        for (j = 0; j < nElems; j++) {
            if (getElem(j) % 2 == 0)
                par++;
            else nepar++;
        }
        System.out.println("Парных чисел в масиве = " + par + ";\nПарных чисел в масиве = " + nepar+ ";");
    }

    public void ZaminaZnacheniyNeparnih(int nElems) {
        System.out.println("Для замены всех непарных елементов, введите елемент-замену: ");
        int zamena = in.nextInt();
        for (j = 0; j < nElems; j++) {
            if (getElem(j) % 2 == 1)
                setElem(j, zamena);
        }
    }

    public long getElem(int index) { // Читання елемента
        return a[index];
    }

} // Кінець класу LowArray