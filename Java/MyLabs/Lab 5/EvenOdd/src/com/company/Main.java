package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.print("Введите размер создаваемого стека:");
        int size = in.nextInt();
        StackX theStack = new StackX(size); // Створення нового стека
        System.out.print("Введите количество данных, что вы собираетесь занести:");
        byte kolvo = in.nextByte();
        long num;
        for(int i = 0;i < kolvo;i++){
            num = in.nextLong();
            theStack.push(num);// Занесення елементів в стек
        }
        StackX parni = new StackX(size);
        StackX neparni = new StackX(size);
        for(int i = 0;i < kolvo;i++){
            long value = theStack.pop();
            if (value % 2 == 0)
                parni.push(value);
            else if(value % 2 == 1)
                neparni.push(value);
        }
        System.out.print("Парные числа: ");
        for(int i = 0;i < size;i++){
            if (parni.isEmpty())
                break;
            long value = parni.pop(); // Видалити елемент зі стеку
            System.out.print(value); // Вивід вмісту
            if (parni.isEmpty())
                break;
            System.out.print(", ");
        }
        System.out.print("\nНепарные числа: ");
        for(int i = 0;i < size;i++){
            if (neparni.isEmpty())
                break;
            long value = neparni.pop(); // Видалити елемент зі стеку
            System.out.print(value); // Вивід вмісту
            if (neparni.isEmpty())
                break;
            System.out.print(", ");
        }

    }
}
