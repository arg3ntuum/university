package com.company;
import java.util.Scanner;

public class Vishnya implements SadoveDerevo {
        Scanner in = new Scanner(System.in);
        String name = "Вишня";
        private int vozrast = 2;

        private int cvetu = 0;
        private int vSnegu = 0;
        private int plodonishu = 0;
        private int opaloListya = 0;
        private int peresazheno = 0;

        @Override
        public void peresadka () {
                if (vozrast > 2 && peresazheno == 0){
                        int da = 0;
                        System.out.println(name + " " + vozrast + " лет. Пересаживаем?(1-да, любое другое - нет): ");
                        da = in.nextInt();
                        if(da == 1) {
                                for(int i = 0;i < 10;i++)
                                        System.out.println(name + " пересаживаем " + "..." +"    "+ i + "0%");
                                System.out.println("Дерево пересажено!");
                                peresazheno = 1;
                        }
                }
                else if (vozrast <= 2)System.out.println("Пересадка невозможна! Дереву' " + name + "' мало лет(возраст > 2)! Ему: " + vozrast + " годик(а)!");
                else if (peresazheno == 1)System.out.println("Дерево уже пересадили!");
        }
        @Override
        public void cvisti () {
                if (vSnegu == 0 && opaloListya == 0 && plodonishu == 0) {
                        if (cvetu == 0) {
                                int da = 0;
                                System.out.println(name + " приказать цвести дереву?(1-да, любое другое - нет): ");
                                da = in.nextInt();
                                if(da == 1) {
                                        for(int i = 0;i < 10;i++)
                                                System.out.println(name + " цветет " + "..." +"    "+ i + "0%");
                                        System.out.println("Дерево отсцвело! Плоды зародились!");
                                        cvetu = 1;
                                }
                        }
                        else if (cvetu == 1)System.out.println("Дерево уже отцвело!");
                }
                else if (vSnegu == 1)System.out.println("Дерево в снегу!");
                else if (opaloListya == 1 && plodonishu == 1 && vSnegu == 0)
                        System.out.println("У дерева нет листьев! Ему нужно поспать в снегу!");
                else if (opaloListya == 0 && plodonishu == 1 && vSnegu == 0)
                        System.out.println("Дерево уже плодоносило. Теперь нужно скинуть листья.");
        }
        @Override
        public void plodonocit () {
                if (vSnegu == 0 && opaloListya == 0 && cvetu == 1) {
                        if (plodonishu == 0) {
                                int da = 0;
                                System.out.println(name + " приказать принести плоды?(1-да, любое другое - нет): ");
                                da = in.nextInt();
                                if (da == 1) {
                                        for (int i = 0; i < 10; i++)
                                                System.out.println(name + " плодоносит " + "..." + "    " + i + "0%");
                                        System.out.println("Дерево принесло плоды!");
                                        plodonishu = 1;
                                }
                        } else if (plodonishu == 1) System.out.println("Дерево уже плодоносило!");
                }
                else if (vSnegu == 1)System.out.println("Дерево в снегу!");
                else if (opaloListya == 1 && vSnegu == 0)
                        System.out.println("У дерева нет листьев! Ему нужно поспать в снегу!");
                else if (cvetu == 0 && plodonishu == 0 && vSnegu == 0)
                        System.out.println("Дерево еще не отцвело. Чтобы были плоды, нужно отцвести.");
        }
        @Override
        public void padinnyaListya (){
                if (vSnegu == 0 && cvetu == 1 && plodonishu == 1) {
                        if (opaloListya == 0) {
                                int da = 0;
                                System.out.println(name + " приказать опасть дереву?(1-да, любое другое - нет): ");
                                da = in.nextInt();
                                if (da == 1) {
                                        for (int i = 0; i < 10; i++)
                                                System.out.println(name + " опадает " + "..." + "    " + i + "0%");
                                        System.out.println("Дерево опало!");
                                        opaloListya = 1;
                                }
                        } else if (opaloListya == 1) System.out.println("Дерево уже опадало!");
                }
                else if (vSnegu == 1)System.out.println("Дерево в снегу!");
                else if (cvetu == 0 && plodonishu == 0 && vSnegu == 0)
                        System.out.println("Дерево еще не отцвело. Чтобы опасть, нужно отцвести.");
                else if (cvetu == 1 && plodonishu == 0 && vSnegu == 0)
                        System.out.println("Дерево еще не плодоносило. Теперь нужно принести плоды.");
        }
        @Override
        public void pokritisyaSnigom () {
                byte da = 0;
                do {
                        if(vSnegu == 0)
                                System.out.println("На данный момент дерево без снега. Дерево '" + name + "' покрыть снегом?(1 - да, 0 - нет): ");
                        else System.out.println("На данный момент дерево в снегу. Дерево '" + name + "' приказать скинуть снег?(1 - да, 0 - нет): ");;
                        da = in.nextByte();
                        if (da == 1 || da == 0)
                                break;
                } while(true);
                if (da == 1 && vSnegu == 0)
                        vSnegu = 1;
                else if (da == 1 && vSnegu == 1) {
                        plodonishu = 0;
                        opaloListya = 0;
                        peresazheno = 0;
                        vSnegu = 0;
                        cvetu = 0;
                }
        }
}
