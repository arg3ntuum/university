package com.company;
import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
        double x = 0, y = 0, result = 0,sum = 0,  raznica = 0;
        int choose = 0, choose2 = 0;
        Scanner input = new Scanner(System.in);

        System.out.print("Введите x: ");
        x = input.nextDouble();
        System.out.print("Введите y: ");
        y = input.nextDouble();

        do {
            System.out.println("\nВыберите одно из действий: " +
                    "\n1.Выполнить сравнение" +
                    "\n2.Выполнить действия: сумма и умножить на 10 \tили \tотнять и умножить на 5" +
                    "\n3.Изменить числа" +
                    "\nВыйти - 0");
            choose = input.nextInt();
            if (choose == 0)
                break;
            else if (choose == 1) {
                if (x < y)
                    System.out.printf("%.0f < %.0f", x, y);
                else if (x > y)
                    System.out.printf("%.0f > %.0f", x, y);
                else System.out.printf("%.0f = %.0f", x, y);
            }
            else if (choose == 2) {
                do {
                    System.out.println("Выберите одно из действий:\n1.Суммировать\n2.Отнять\n0.Exit\nВаш выбор: ");
                    choose2 = input.nextInt();
                    if (choose2 == 0)
                        break;
                    else if (choose2 == 1) {
                        sum = (x+y);
                        System.out.print("\nИсходные данные: x = " + x + " y = " + y + "\nCумма = " + sum);
                        result = 10 *sum;
                        System.out.println("\nCумму умножить в 10 раз = " + result);
                    }
                    else if (choose2 == 2) {
                        System.out.print("\nИсходные данные: x = " + x + "\ty = " + y + "\nРазница = " + (x-y));
                        raznica = (x - y) * 5;
                        System.out.println("\nРазница и умножение в 5 раз= " + raznica);
                    }
                } while (true);
            }
            else if (choose == 3) {
                System.out.print("Введите x: ");
                x = input.nextDouble();
                System.out.print("Введите y: ");
                y = input.nextDouble();
            }
        } while (true);
    }
}

