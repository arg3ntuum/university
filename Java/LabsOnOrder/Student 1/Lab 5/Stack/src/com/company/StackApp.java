package com.company;
import java.util.Scanner;
public class StackApp {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        System.out.print("Уведіть розмір створюванного стека:");
        int size = in.nextInt();
        StackX theStack = new StackX(size); // Створення нового стека
        System.out.print("Уведіть кількість данних, що ви хочете занести:");
        byte kolichestvo = in.nextByte();
        long num;
        for(int i = 0;i < kolichestvo;i++){
            num = in.nextLong();
            theStack.push(num);// Занесення елементів в стек
        }
        System.out.print("Уведіть кількість данних для виведення:");
        byte kil = in.nextByte();
        for(int i = 0;i < kil;i++){
            if (theStack.isEmpty())
                break;
            long value = theStack.pop(); // Видалити елемент зі стеку
            System.out.println(value); // Вивід вмісту
        }
        System.out.println("");
    } } // Кінець класу StackApp