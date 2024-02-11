package com.company;
import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
        byte choose = 0, choose_move = 0, choose_zp = 0, choose_kr = 0, choose_keruv = 0, exit = 0;
        Scanner in = new Scanner(System.in);
        Inzhener inzh = new Inzhener();
        Brigadir brig = new Brigadir();
        do {
        do {
            System.out.println("Выберете сотрудника, c которым хотите взаимодействовать(1-инженер, 2-бригадир): ");
            choose = in.nextByte();
            if (choose == 1 || choose == 2)
                break;
        } while (true);
        if (choose == 1)
        {
            /*    INZHENER   INZHENER   INZHENER   INZHENER   INZHENER   INZHENER   INZHENER   */
            do{
                System.out.println("Выберете вкладку\n1.Зарплата;\n2.Креслення;\n3.Управлять;\n0.Exit;\nВаш выбор: ");
                choose_move = in.nextByte();
                if (choose_move == 0)
                    break;
                if (choose_move == 1)
                {
                    do {
                        System.out.println("Текущая зарплата: " + inzh.zp);
                        System.out.println("Сотрудника устраивает текущая зп(1-дa, 2-нет)?");
                        choose_zp = in.nextByte();
                        if(choose_zp == 1)
                            break;
                        else if ( choose_zp == 2)
                            inzh.perechet();
                    } while(true);
                }
                else if (choose_move == 2)
                {
                    do {
                        System.out.println("Инженера отправить рисовать?(1-дa, 2-нет)?");
                        choose_kr = in.nextByte();
                        if(choose_kr == 1)
                            inzh.kresliti();
                        else if ( choose_kr == 2)
                            break;
                    } while(true);
                }
                else if (choose_move == 3)
                {
                    inzh.keruvati();
                }
            }while(true);
        }
        else
        {
                /*    BRIGADIR   BRIGADIR   BRIGADIR   BRIGADIR   BRIGADIR   BRIGADIR   BRIGADIR   */
                do{
                    System.out.println("Выберете вкладку\n1.Зарплата;\n2.Креслення;\n3.Управлять;\n0.Exit;\nВаш выбор: ");
                    choose_move = in.nextByte();
                    if (choose_move == 0)
                        break;
                    if (choose_move == 1)
                    {
                        do {
                            System.out.println("Текущая зарплата: " + brig.zp);
                            System.out.println("Сотрудника устраивает текущая зп(1-дa, 2-нет)?");
                            choose_zp = in.nextByte();
                            if(choose_zp == 1)
                                break;
                            else if ( choose_zp == 2)
                                brig.perechet();
                        } while(true);
                    }
                    else if (choose_move == 2)
                    {
                        brig.kresliti();
                    }
                    else if (choose_move == 3)
                    {
                        do {
                            if (choose_keruv == 0)
                                System.out.println("Бригадир на данный момент отдыхает!");
                                else System.out.println("Бригадир на данный момент управляет!");
                            System.out.println("Отдать распоряжение бригадиру?(1-да, 2-нет)?");
                            choose_kr = in.nextByte();
                            if(choose_kr == 1)
                                choose_keruv = brig.keruvati();
                            else if ( choose_kr == 2)
                                break;
                        } while(true);
                    }
                }while(true);
            }
        System.out.println("Вы хотите продолжить работу(0-нет или любое число): ");
        exit = in.nextByte();
        if(exit == 0)
            break;
        } while(true);
    }
}
