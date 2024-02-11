package com.company;
import java.util.Scanner;
import java.lang.*;

public class LowArrayApp {//Початок класу LowArrayApp

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        LowArray arr; // Посилання
        arr = new LowArray(100); // Створення об’єкта LowArray
        long newElement = 0;
        int j=0,nElems = 0,end = 0, choose = 0, choseKey = 0, paired = 0, nonPaired = 0, replacement = 0;
        //long min , max ;
        arr.setElem(0, 77); // Вставка 5 елементів
        arr.setElem(1, 99);
        arr.setElem(2, 44);
        arr.setElem(3, 55);
        arr.setElem(4, 22);
        nElems = 5; // Масив містить 5 елементів
        for (j = 0; j < nElems; j++) // Вивід елементів
            System.out.print(arr.getElem(j) + " ");
        System.out.println("");
        do {
            do {
                System.out.println("Выберите одно из действий: \n" +
                        "1.Пошук елементів в масиві по заданому значенню;\n" +
                        "2.Видалення значень в масиві по заданому значенню;\n" +
                        "3.Виведення вмісту масиву; \n" +
                        "4.Знаходження максимального і мінімального елемента в масиві; \n" +
                        "5.Підрахунок кількості парних і непарних значень; \n" +
                        "6.Заміна всіх непарних значень масиву на вказане значення; \n" +
                        "7.Добавити елемент; \n" +
                        "0.Exit. \nВаш выбор:");
                choose = in.nextInt();
                if (choose >= 0 &&  choose <= 7)
                    break;
            } while (true);

            switch (choose) {
                case 0:
                    return;
                case 1:
                    System.out.println("Впишіть значення для пошуку: ");
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
                    System.out.println("Впишіть значення для видалення: ");
                    choseKey = in.nextInt(); // Выбор елемента
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
                    }
                    System.out.println("min = " + min + ", а max = " + max);
                    break;
                case 5:
                    for (j = 0; j < nElems; j++) {
                        if (arr.getElem(j) % 2 == 0)
                            paired++;
                        else nonPaired++;
                    }
                    System.out.println("Парні = " + paired + ", а не парні = " + nonPaired);
                    break;
                case 6:
                    System.out.println("Для заміни усіх непарних значень на вказане уведіть його: ");
                    replacement = in.nextInt();
                    for (j = 0; j < nElems; j++) {
                        if (arr.getElem(j) % 2 == 1)
                            arr.setElem(j, replacement);
                    }
                    break;
                case 7:
                    System.out.println("Для добавлення нового елемента уведіть його: ");
                    newElement = in.nextLong();
                    arr.setElem(nElems, newElement);
                    nElems++;
                    break;
                default:
                    ;
                    break;
            }
            System.out.println("Для завершення уведіть 0 або інше для продовження");
            end = in.nextInt();
            if (end == 0)
                break;
        }while(true);
    }
}// Кінець класу LowArrayApp
