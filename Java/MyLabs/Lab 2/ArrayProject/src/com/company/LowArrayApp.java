package com.company;
import java.util.Scanner;
import java.lang.*;

public class LowArrayApp {//Початок класу LowArrayApp

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        LowArray arr; // Посилання

        arr = new LowArray(100); // Створення об’єкта LowArray

        int nElems = 0; // Кількість елементів у масиві

        int j; // Змінна циклу

        arr.setElem(0, 77); // Вставка 5 елементів

        arr.setElem(1, 99);

        arr.setElem(2, 44);

        arr.setElem(3, 55);

        arr.setElem(4, 22);

        nElems = 5; // Масив містить 5 елементів

        for (j = 0; j < nElems; j++) // Вивід елементів
            System.out.print(arr.getElem(j) + " ");
        int choose = 0;
        System.out.println("");
        do {
            do {
                System.out.println("Виберіть дію: \n" +
                        "1.Пошук елементів в масиві по заданому значенню;\n" +
                        "2.Видалення значень в масиві по заданому значенню;\n" +
                        "3.Виведення вмісту масиву; \n" +
                        "4.Знаходження максимального і мінімального елемента в масиві; \n" +
                        "5.Підрахунок кількості парних і непарних значень; \n" +
                        "6.Заміна всіх непарних значень масиву на вказане значення; \n" +
                        "0.Exit. \nВаш выбор:");
                choose = in.nextInt();
                if (choose == 0 || choose == 1 || choose == 2 || choose == 3|| choose == 4 || choose == 5 || choose == 6)
                    break;
            } while (true);

            switch (choose) {
                case 0:
                    return;
                case 1:
                    System.out.println("Впишіть значення в масив, яке ви хочите знайти: ");
                    int searchKey = in.nextInt(); // Пошук елемента
                    for (j = 0; j < nElems; j++) // Для кожного елемента
                        if (arr.getElem(j) == searchKey) // Значення знайдено?
                            break;
                    if (j == nElems) // Ні
                        System.out.println("Значення " + searchKey + " не було знайдено.");
                    else // Так
                        System.out.println("Значення " + searchKey + " було знайдено.");
                    break;
                case 2:
// Видалення елемента з ключем 55
                    System.out.println("Впишіть значення в масив, яке ви хочите видалити: ");
                    int choseKey = in.nextInt(); // Выбор елемента

                    for (j = 0; j < nElems; j++) // Пошук елемента, що видаляється
                        if (arr.getElem(j) == choseKey)
                            break;
                    for (int k = j; k < nElems; k++) // Переміщення наступних елементів
                        arr.setElem(k, arr.getElem(k + 1));
                    nElems--; // Зменшення розміру
                    break;
                case 3:
                    System.out.print("Ваш масив:");
                    for (j = 0; j < nElems; j++) // Вивід вмісту
                        System.out.print(arr.getElem(j) + " ");
                    System.out.println("");
                    break;
                case 4:
                    long min = arr.getElem(0), max = arr.getElem(0);
                    for (j = 0; j < nElems; j++) {
                        if (min > arr.getElem(j))
                            min = arr.getElem(j);
                        else if (max < arr.getElem(j))
                            max = arr.getElem(j);
                        else;
                    }
                    System.out.println("Мінімальне значення: " + min + ", а максимальне значення :" + max);
                    break;
                case 5:
                    int par = 0, nepar = 0;
                    for (j = 0; j < nElems; j++) {
                        if (arr.getElem(j) % 2 == 0)
                            par++;
                        else nepar++;
                    }
                    System.out.println("Кількість парних чисел: " + par + ", а кількость не парних : " + nepar);
                    break;
                case 6:
                    System.out.println("Для заміни усіх непарних значень на вказане значення уведіть його: ");
                    int zamena = in.nextInt();
                    for (j = 0; j < nElems; j++) {
                        if (arr.getElem(j) % 2 == 1)
                            arr.setElem(j, zamena);
                        else;
                    }
                    break;
                default:
                    ;
                    break;
            }
            System.out.println("Для завершения уведіть 0, для продовження у будь-який інший символ");
            int konec = in.nextInt();
            if (konec == 0)
                break;
        }while(true);
    }
}// Кінець класу LowArrayApp
