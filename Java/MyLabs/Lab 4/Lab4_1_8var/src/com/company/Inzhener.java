package com.company;
import java.util.Scanner;

public class Inzhener implements Sotrudnik {
        Scanner in = new Scanner(System.in);
        ////Рисовать
        @Override
        public void kresliti () {
                String str;
                System.out.println("Введите то, что вы прикажете рисовать: ");
                str = in.nextLine();
                for(int i = 0;i < 10;i++)
                        System.out.println("Рисуем " + str+ "..." +"    "+ i + "0%");
                System.out.println("Схема нарисована!");
        }

        ////Керувати
        @Override
        public byte keruvati () {
                System.out.println("Инженер не может управлять бригадой! Обратитесь к бригадиру!");
                return 0;
        }

        ////Зарплата
        int zp = 6000;
        @Override
        public int perechet() {
                do {
                        System.out.println("Введите количество заработной платы между " + Sotrudnik.min_zp + " и " + max_zp + ": ");
                        zp = in.nextInt();
                        if (zp >= min_zp && zp <=max_zp)
                                break;
                } while(true);
                return zp;
        }
}
