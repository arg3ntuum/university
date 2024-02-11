package com.company;
import com.company.ArrayBub;
import java.util.Scanner;

public class BubbleSortApp {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int maxSize = 100; // Розмір масиву
        byte storona = 0;
        ArrayBub arr; // Посилання на масив
        arr = new ArrayBub(maxSize); // Створення масиву
        System.out.println("Введите количество цифр, что вы хотите рандомно присвоить в массив: ");
        int kolvo = in.nextInt();
        for (byte i = 0;i < kolvo;i++)
        {
            int n =(int)(java.lang.Math.random()*(maxSize - 1));
            arr.insert(n);
        }
        arr.display(); // Вивід елементів
        do {
            System.out.println("Введите в какую сторону вы будете сортировать массив(1 - к большему, 2 - к меньшему): ");
            storona = in.nextByte();
            if (storona == 1 || storona == 2)
                break;
        }while(true);

        arr.bubbleSort(storona); // Бульбашкове сортування елементів
        arr.bubbleSort(storona); // Бульбашкове сортування елементів
        arr.display(); // Повторний вивід
    }
} // Кінець класу BubbleSortApp
