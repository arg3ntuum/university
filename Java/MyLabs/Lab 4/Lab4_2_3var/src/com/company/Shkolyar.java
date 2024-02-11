package com.company;

public class Shkolyar extends Uchen{
    public int clas;
    @Override
    public byte robutu_uroki () {
        byte delayu = 0;
        do {
            System.out.println("Отправить " + this.Firstname + " делать дз?(1-да, 2-нет)");
            delayu = in.nextByte();
            if (delayu == 1)
                return delayu;
            else if (delayu == 2) {
                delayu = 0;
                return delayu;
            }
        }while(true);
    }
    @Override
    public void bigati () {
        for(int i = 0;i < 10;i++)
            System.out.println("Бегаем..." +"    "+ i + "0%");
        System.out.println("ПРОБЕЖАЛИСЬ! Я ЗАПЫХАЛСЯ!");
    }
    public Shkolyar (String name, String last,int clas){//
        Firstname = name;
        Lastname = last;
        this.clas = clas;
    }
}
