package com.company;

import java.util.Scanner;

public class Main {
    public static float devide(float a, float b) {return a / b;}

    public static float multi(float a, float b) {
        return a * b;
    }

    public static float sum(float a, float b) {
        return a + b;
    }

    public static float minus(float a, float b) {
        return a - b;
    }

    public static void main(String[] args) {
        int  choose;
        float x, y;
        Scanner in = new Scanner(System.in);
        do {
            System.out.print("Уведіть x: ");
            x = in.nextFloat();
            System.out.print("Уведіть y: ");
            y = in.nextFloat();
            do {
                System.out.print("Вибір дії:\n1.Помножити;\n2.Поділити;\n3.Додати;\n4.Відняти;\nВаш вибір: ");
                choose = in.nextInt();
                if (choose >= 1 && choose <= 4)
                    break;
            } while (true);

            switch (choose) {
                case 1:System.out.print("Множення: x * y = " + x + " * " + y + " = " +  multi(x, y)); break;
                case 2:System.out.print("Ділення: x / y = " + x + " / " + y + " = " + devide(x,y)); break;
                case 3:System.out.print("Додавання: x + y = " + x + " + " + y + " = " + sum(x, y));break;
                case 4:System.out.print("Віднімання: x + y = " + x + " - " + y + " = " + minus(x, y));break;
            }
            System.out.print("\nДля завершення роботи уведіть нуль, в іншому разі - будь-яке інше число: ");
            choose = in.nextInt();
            if (choose == 0)
                break;
        } while (true);
    }
}
