package com.company;
import java.util.Scanner;

public class InsertSortApp {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int maxSize = 100; // Розмір масиву
        ArrayIns arr; // Посилання на масив
        arr = new ArrayIns(maxSize); // Створення масиву
        System.out.println("Уведіть кількість чисел для визначення масиву: ");
        int kolvo = in.nextInt();
        for (byte i = 0; i < kolvo; i++) {
            int n = (int) (java.lang.Math.random() * 10);
            arr.insert(n);
        }
        arr.display();
        arr.insertionSort();
        arr.display();
        System.out.println("Медіана: " + arr.medianFound());
    }
}
