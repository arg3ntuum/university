package com.company;

public class Terapevt extends Likar{
    public Terapevt (String name, String last,String kvalification){//
        Firstname = name;
        Lastname = last;
        this.kvalification = kvalification;
    }
    @Override
    public void likuvati () {
        if (zanyatost == 0) {
            for(int i = 0;i < 10;i++)
                System.out.println("Лечу больных..." +"    "+ i + "0%");
            System.out.println("Полечил больных!");
        }
        else System.out.println("Я принимаю больных!");
    }
    @Override
    public void operirovat () {System.out.println("Я не могу оперировать. Этим занимается наш хирург!");}
    @Override
    public void prinimat () {
        if (zanyatost == 0) {
            System.out.println("На данный момент " + this.Firstname + " не занят.");
            byte delayu = 0;
            do {
                System.out.println("Отправить " + this.Firstname + " принимать больных?(1-да, 2-нет)");
                delayu = in.nextByte();
                if (delayu == 1) {
                    zanyatost = 1;
                    return;
                }
                else if (delayu == 2)
                    return;
            }while(true);
        }
        else {
            System.out.println("На данный момент " + this.Firstname + " принимает больных.");
            byte delayu = 0;
            do {
                System.out.println("Отправить " + this.Firstname + " отдыхать?(1-да, 2-нет)");
                delayu = in.nextByte();
                if (delayu == 1) {
                    zanyatost = 0;
                    return;
                }
                else if (delayu == 2)
                    return;
            }while(true);
        }
    }
}
