package com.company;
import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
        double x = 0, y = 0, result = 0,sum = 0;
        int choose = 0, choose2 = 0;
        Scanner vvedennya = new Scanner(System.in);

        System.out.print("Уведіть x: ");
        x = vvedennya.nextDouble();
        System.out.print("Уведіть y: ");
        y = vvedennya.nextDouble();

        do {
            System.out.println("\nВиберіть дію: " +
                    "\n1.Порівняти;" +
                    "\n2.Виберіть дію: сумувати й помножити на 10 \tабо \tвідняти й помножити на 5" +
                    "\n3.Змінити числа" +
                    "\nВихід - 0" +
                    "\nВаш вибір:");
            choose = vvedennya.nextInt();
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
                    System.out.println("Виберіть одно из дій:\n1.Сумувати;\n2.Відняти;\n0.Exit;\nВаш вибір: ");
                    choose2 = vvedennya.nextInt();
                    if (choose2 == 0)
                        break;
                    else if (choose2 == 1) {
                        sum = (x+y);
                        System.out.print("\nВихідні данні: x = " + x + " y = " + y + "\nCума = " + sum);
                        result = 10 *sum;
                        System.out.println("\nCуму множити у 10 разів = " + result);
                    }
                    else if (choose2 == 2) {
                        System.out.print("\nВихідні данні: x = " + x + "\ty = " + y + "\nРізниця = " + (x-y));
                        result = (x - y) * 5;
                        System.out.println("\nРізниця и множення в 5 разів = " + result);
                    }
                } while (true);
            }
            else if (choose == 3) {
                System.out.print("Уведіть x: ");
                x = vvedennya.nextDouble();
                System.out.print("Уведіть y: ");
                y = vvedennya.nextDouble();
            }
        } while (true);
    }
}

