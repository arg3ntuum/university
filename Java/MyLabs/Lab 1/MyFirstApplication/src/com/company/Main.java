package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        double a, b, summa = 0, riznicya = 0;
        Scanner scan = new Scanner(System.in);

        System.out.printf("Введите a: ");
        a = scan.nextDouble();
        System.out.printf("Введите b: ");
        b = scan.nextDouble();

        int choose, choose2;
        do {
            System.out.println("Выбере одно из действий: " +
                    "\n1.Сравнять" +
                    "\n2.Выполнить действия: сумма*10 \tили\t різниця*5" +
                    "\nВыйти - 0");
            choose = scan.nextInt();
            if (choose == 0 || choose == 1 || choose == 2)
                break;
        } while (true);
        if (choose == 1) {
            if (a < b) {
                System.out.printf("%.0f < %.0f", a, b);
            } else if (a > b) {
                System.out.printf("%.0f > %.0f", a, b);
            } else {
                System.out.printf("%.0f = %.0f", a, b);
            }
        }
        if (choose == 2) {
            do {
                System.out.println("Выбере одно из действий:\n1.Суммировать\n2.Отнять\nВаш выбор: ");
                choose2 = scan.nextInt();
                if (choose2 == 1 || choose2 == 2)
                    break;
            } while (true);
            if (choose2 == 1) {
                System.out.printf("\nИсходные данные: a = " + a + "b = " + b + "\nCуммирование = " + (a+b));
                for (int i = 0;i <= 10; i++)
                    summa += a + b;
                System.out.println("\nCуммирование и умножение в 10 раз= " + summa);
            }
            if (choose2 == 2)
                System.out.printf("\nИсходные данные: a = " + a + "\tb = " + b + "\nРазница = " + (a-b));
            for (int i = 0;i < 5; i++)
                riznicya += a - b;
            System.out.println("\nРазница и умножение в 5 раз= " + riznicya);
        }
    }
}

