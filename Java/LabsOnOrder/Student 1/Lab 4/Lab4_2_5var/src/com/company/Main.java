package com.company;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int choose = 0, choose_pers = 0, choose_uprav;
        Hirurgh hirurgh = new Hirurgh("Vitya", "Archipov", "Hirurugh:1S");
        Terapevt terapevt = new Terapevt("Grisha", "Gogynskiy", "Terapevt:2B");
        System.out.println("Здравствуйте, главврач!");
        do {
            System.out.println("Выберите способ создания ваших врачей (1 - процедурный, 2 - ручной): ");
            choose = in.nextInt();
            if (choose == 1 )
                break;
            else if(choose == 2)
            {
                System.out.println("Создадим хирурга!");
                System.out.print("Введите имя:");
                String name_1 = in.next();
                System.out.print("Введите фамилию:");
                String name_2 = in.next();
                System.out.print("Введите квалификацию:");
                String name_3 = in.next();
                hirurgh = new Hirurgh(name_1, name_2, name_3);

                System.out.println("Создадим терапевта!");
                System.out.print("Введите имя:");
                name_1 = in.next();
                System.out.print("Введите фамилию:");
                name_2 = in.next();
                System.out.print("Введите квалификацию:");
                name_3 = in.next();
                terapevt = new Terapevt(name_1, name_2, name_3);
                break;
            }
            else System.out.println("Введите корректные данные!");
        } while(true);
        do {
            System.out.print("Выберите персонажа:\n1.Хирург;\n2.Терапевт;\n0.EXIT\nВаш выбор: ");
            choose_pers = in.nextInt();
            if (choose_pers == 0)
                break;
            else if (choose_pers == 1) {
                do {
                    System.out.print("Управление вашим персонажем:\n1.Вывести всю доступную информацию."
                                                                +"\n2.Лечить."
                                                                +"\n3.Оперировать."
                                                                +"\n4.Принимать."
                                                                +"\n0.EXIT"
                                                                +"\nВаш выбор: ");
                    choose_uprav = in.nextInt();
                    if (choose_uprav == 0)
                        break;
                    else if(choose_uprav == 1)
                        hirurgh.dannyie();
                    else if  (choose_uprav == 2)
                        hirurgh.likuvati();
                    else if  (choose_uprav == 3)
                        hirurgh.operirovat();
                    else if  (choose_uprav == 4)
                        hirurgh.prinimat();
                    else System.out.println("Введите корректные данные!");
                } while(true);
            }
            else if (choose_pers == 2) {
                do {
                    System.out.print("Управление вашим персонажем:\n1.Вывести всю доступную информацию."
                                                                +"\n2.Лечить."
                                                                +"\n3.Оперировать."
                                                                +"\n4.Принимать."
                                                                +"\n0.EXIT"
                                                                +"\nВаш выбор: ");
                    choose_uprav = in.nextInt();
                    if (choose_uprav == 0)
                        break;
                    else if(choose_uprav == 1)
                        terapevt.dannyie();
                    else if  (choose_uprav == 2)
                        terapevt.likuvati();
                    else if  (choose_uprav == 3)
                        terapevt.operirovat();
                    else if  (choose_uprav == 4)
                        terapevt.prinimat();
                    else System.out.println("Введите корректные данные!");
                } while(true);
            }
        }while(true);
    }
}
