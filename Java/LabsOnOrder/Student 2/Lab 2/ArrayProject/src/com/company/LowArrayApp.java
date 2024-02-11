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

        // Вставка 5 елементів
        arr.setElem(0, 77);
        arr.setElem(1, 99);
        arr.setElem(2, 44);
        arr.setElem(3, 55);
        arr.setElem(4, 22);

        nElems = 5; // Масив містить 5 елементів

        arr.OutPut(nElems);

        int choise = 0;//змінна вибору
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
                        "0.Exit. " +
                        "\nВаш вибір:");
                choise = in.nextInt();
                if (choise >= 0 &&  choise <= 6)
                    break;
            } while (true);
            switch (choise) {
                case 0: return;
                case 1: arr.PoiskElementa(nElems); break;
                case 2: nElems = arr.UdalitElement(nElems); break;
                case 3: arr.OutPut(nElems); break;
                case 4: arr.MinAndMax(nElems); break;
                case 5: arr.ZnaytiParniTaNeparni(nElems); break;
                case 6: arr.ZaminaZnacheniyNeparnih(nElems); break;
                default: break;
            }
        }while(true);
    }
}// Кінець класу LowArrayApp
