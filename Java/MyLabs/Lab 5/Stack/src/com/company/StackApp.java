package com.company;
import java.util.Scanner;
public class StackApp {

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
        System.out.print("Введите количество данных, что вы собираетесь выводить:");
        byte kil = in.nextByte();
        for(int i = 0;i < kil;i++){
            if (theStack.isEmpty())
                break;
            long value = theStack.pop(); // Видалити елемент зі стеку
            System.out.println(value); // Вивід вмісту
        }
        System.out.println("");
    } } // Кінець класу StackApp