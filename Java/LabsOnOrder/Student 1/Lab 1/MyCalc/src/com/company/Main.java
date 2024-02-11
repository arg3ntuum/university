package com.company;

import java.util.Scanner;

public class Main {
    public static int deleniye(int a, int b) {
        return a / b;
    }

    public static int umnozheniye(int a, int b) {
        return a * b;
    }

    public static int summa(int a, int b) {
        return a + b;
    }

    public static int minus(int a, int b) {
        return a - b;
    }

    public static void main(String[] args) {
        int x, y, choose;
        Scanner in = new Scanner(System.in);
        do {
            System.out.print("Введите а: ");
            x = in.nextInt();
            System.out.print("Введите y: ");
            y = in.nextInt();
            do {
                System.out.print("Выбор действия:\n1.Умножить\n2.Поделить\n3.Просуммировать\n4.Отнять\nВаш выбор: ");
                choose = in.nextInt();
                if (choose >= 1 && choose <= 4)
                    break;
            } while (true);

            switch (choose)
            {
                case 1:System.out.print("Умножение: x * y = " + x + " * " + y + " = " +  umnozheniye(x, y)); break;
                case 2:System.out.print("Деление: x / y = " + x + " / " + y + " = " + deleniye(x, y)); break;
                case 3:System.out.print("Суммирование: x + y = " + x + " + " + y + " = " + summa(x, y));break;
                case 4:System.out.print("Отнимание: x + y = " + x + " - " + y + " = " + minus(x, y));break;
            }
            System.out.print("\nДля выхода введите 0, для продолжение - любое другое число: ");
            choose = in.nextInt();
            if (choose == 0)
                break;
        } while (true);
    }
}
