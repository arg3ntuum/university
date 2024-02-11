package com.company;
import java.util.Scanner;

public class InsertSortApp {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int maxSize = 100; // Розмір масиву
        ArrayIns arr; // Посилання на масив
        arr = new ArrayIns(maxSize); // Створення масиву
        System.out.println("Введите количество елементов в массиве: ");
        int nElements = in.nextInt();
        for (byte i = 0; i < nElements; i++)
            arr.insert((int) (java.lang.Math.random() * 10));
        arr.display();
        arr.insertionSort();
        arr.display();
        System.out.println("Медиана: " + arr.median());
    }
}
