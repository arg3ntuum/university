package com.company;

public class Hirurgh extends Likar{
    public Hirurgh (String name, String last,String kvalification){//
        Firstname = name;
        Lastname = last;
        this.kvalification = kvalification;
    }
    @Override
    public void likuvati () {System.out.println("Я не могу лечить больных. Этим занимается наш терапевт!");}
    @Override
    public void operirovat () {
        if (zanyatost == 0) {
            System.out.println("На данный момент " + this.Firstname + " не занят.");
            byte delayu = 0;
            do {
                System.out.println("Отправить " + this.Firstname + " оперировать?(1-да, 2-нет)");
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
            System.out.println("На данный момент " + this.Firstname + " оперирует.");
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
    @Override
    public void prinimat () {System.out.println("Я не могу принимать больных. Этим занимается наш терапевт!");}
}
