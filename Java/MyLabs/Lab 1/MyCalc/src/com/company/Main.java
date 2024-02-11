package com.company;

import java.util.Scanner;

public class Main {
    public static int div(int a, int b) {
        return a / b;
    }

    public static int multi(int a, int b) {
        return a * b;
    }

    public static int sum(int a, int b) {
        return a + b;
    }

    public static int dif(int a, int b) {
        return a - b;
    }

    public static void main(String[] args) {
        int a, b;
        byte choose;
        Scanner in = new Scanner(System.in);
        do {
            System.out.print("Введите а: ");
            a = in.nextInt();
            System.out.print("Введите b: ");
            b = in.nextInt();

            do {
                System.out.print("Выбор действия:\n1.Умножение\n2.Деление\n3.Прибавить\n4.Отнять\nВаш выбор: ");
                choose = in.nextByte();
                if (choose >= 1 && choose <= 4)
                    break;
            } while (true);

            switch (choose)
            {
                case 1:System.out.print("Умножение. a * b = " + a + " * " + b + " = " +  multi(a, b)); break;
                case 2:System.out.print("Деление. a / b = " + a + " / " + b + " = " + div(a, b)); break;
                case 3:System.out.print("Сумма. a + b = " + a + " + " + b + " = " + sum(a, b));break;
                case 4:System.out.print("Отнимаем. a + b = " + a + " - " + b + " = " + dif(a, b));break;
            }
            /*
            if (choose == 0)
                break;
            else if (choose == 1)
                System.out.print("Умножение. a * b =" + a + '*' + b + '=' +  multi(a, b));
            else if (choose == 2)
                System.out.print("Деление. a / b =" + a + '/' + b + '=' + div(a, b));
            else if (choose == 3)
                System.out.print("Сумма. a + b =" + a + '+' + b + '=' + sum(a, b));
            else if (choose == 4)
                System.out.print("Отнимаем. a + b =" + a + '+' + b + '=' + dif(a, b));
            else ; */

            System.out.print("\nЕсли хотите продолжить, введите 1, если нет 0: ");
            choose = in.nextByte();
            if (choose == 0)
                break;
        } while (true);
    }
}
