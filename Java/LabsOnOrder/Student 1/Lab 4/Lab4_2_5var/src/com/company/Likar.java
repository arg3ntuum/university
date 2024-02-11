package com.company;
import java.util.Scanner;

abstract class Likar {
    public String Firstname;
    public String Lastname;
    public String kvalification;
    public int zanyatost = 0;
    Scanner in = new Scanner(System.in);
    abstract void likuvati();
    abstract void operirovat();
    abstract void prinimat();
    void dannyie(){
        System.out.println("Данные доктора:\nИмя: " + Firstname+
                                          "\nФамилия: "+ Lastname+
                                          "\nКвалификация: "+ kvalification);
    }
}
