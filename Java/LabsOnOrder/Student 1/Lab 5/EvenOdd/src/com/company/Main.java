package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.print("Уведіть розмір створюванного стека:");
        int size = in.nextInt();
        StackX theStack = new StackX(size); // Створення нового стека
        System.out.print("Уведіть кількість данних, що ви хочете занести:");
        byte kilkist = in.nextByte();
        long num;
        for(int i = 0;i < kilkist;i++){
            num = in.nextLong();
            theStack.push(num);// Занесення елементів в стек
        }
        StackX parni = new StackX(size);
        StackX neparni = new StackX(size);
        for(int i = 0;i < kilkist;i++){
            long value = theStack.pop();
            if (value % 2 == 0)
                parni.push(value);
            else if(value % 2 == 1)
                neparni.push(value);
        }
        System.out.print("Парні: ");
        for(int i = 0;i < size;i++){
            if (parni.isEmpty())
                break;
            long value = parni.pop(); // Видалити елемент зі стеку
            System.out.print(value); // Вивід вмісту
            if (parni.isEmpty())
                break;
            System.out.print(", ");
        }
        System.out.print("\nНепарні: ");
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
