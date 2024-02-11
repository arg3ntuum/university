package com.company;
import com.company.ArrayBub;
import java.util.Scanner;

public class BubbleSortApp {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int maxSize = 100; // Розмір масиву
        byte choose = 0;
        ArrayBub arr; // Посилання на масив
        arr = new ArrayBub(maxSize); // Створення масиву
        System.out.println("Уведіть кількість чисел для визначення масиву: ");
        int size = in.nextInt();
        for (byte i = 0;i < size;i++) {
            int n =(int)(java.lang.Math.random()*(maxSize - 1));
            arr.insert(n);
        }
        arr.display(); // Вивід елементів
        do {
            System.out.println("Виберіть сторону сортування масиву:\n1.До більшого;\n2.До меншого;\nВаш вибір: ");
            choose = in.nextByte();
            if (choose == 1 || choose == 2)
                break;
        }while(true);
        arr.bubbleSort(choose); // Бульбашкове сортування елементів
        arr.display(); // Повторний вивід
    }
} // Кінець класу BubbleSortApp
