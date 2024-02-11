package com.company;
import java.util.Scanner;

public class Brigadir implements Sotrudnik{
    ////Рисовать
    @Override
    public void kresliti () {
        System.out.println("Бригадир не может рисовать! Обратитесь к инженеру!");
    }

    ////Керувати
    @Override
    public byte keruvati () {
        byte keruyu = 0;
        do {
            System.out.println("Прикажите бригадиру управлять(1 - управлять, 0 - отдыхать): ");
            keruyu = in.nextByte();
            if (keruyu == 1 || keruyu == 0)
                break;
        } while(true);
        return keruyu;
    }

    Scanner in = new Scanner(System.in);
    ////Зарплата
    int zp = 6000;
    @Override
    public int perechet() {

        do {
            System.out.println("Введите количество заработной платы между " + Sotrudnik.min_zp + " и " + max_zp + ": ");
            zp = in.nextInt();
            if (zp >= min_zp && zp <=max_zp)
                return zp;
        } while(true);
    }
}
