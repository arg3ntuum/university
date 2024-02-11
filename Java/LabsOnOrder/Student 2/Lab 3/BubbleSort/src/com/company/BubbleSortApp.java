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
        System.out.println("Введите количество елементов масива: ");
        int size = in.nextInt();
        for (byte i = 0;i < size;i++) {
            int n =(int)(java.lang.Math.random()*(maxSize - 1));
            arr.insert(n);
        }
        arr.display(); // Вивід елементів
        do {
            System.out.println("Выберите сторону сортировки массива:\n1.К большему;\n2.К меньшему;\n0.Выход;\nВаш выбор: ");
            choose = in.nextByte();
            if (choose == 0)
                break;
            arr.bubbleSort(choose); // Бульбашкове сортування елементів
            arr.display(); // Повторний вивід
        }while(true);
    }
} // Кінець класу BubbleSortApp
