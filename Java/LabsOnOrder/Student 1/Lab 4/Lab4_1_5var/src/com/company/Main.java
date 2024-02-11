package com.company;
import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
        byte choose = 0, choose_move = 0, exit;
        Scanner in = new Scanner(System.in);
        Vishnya vish = new Vishnya();
        Yablunya yabl = new Yablunya();
        Grusha grusha = new Grusha();
        do {
            do {
                System.out.println("Выберете дерево (1-вишня, 2-яблуня, 3-груша): ");
                choose = in.nextByte();
                if (choose == 1 || choose == 2 || choose == 3)
                    break;
            } while (true);
            if (choose == 1)
                do{
                    System.out.println("Выберете вкладку\n1.Пересадка;\n2.Цвести;\n3.Плодоносит;\n4.Опасть;\n5.Покрыть снегом;\n0.Exit;\nВаш выбор: ");
                    choose_move = in.nextByte();
                    if (choose_move == 0)
                        break;
                    if (choose_move == 1)
                        vish.peresadka();
                    else if (choose_move == 2)
                        vish.cvisti();
                    else if (choose_move == 3)
                        vish.plodonocit();
                    else if (choose_move == 4)
                        vish.padinnyaListya();
                    else if (choose_move == 5)
                        vish.pokritisyaSnigom();
                }while(true);
            else if (choose == 2)
                do{
                    System.out.println("Выберете вкладку\n1.Пересадка;\n2.Цвести;\n3.Плодоносит;\n4.Опасть;\n5.Покрыть снегом;\n0.Exit;\nВаш выбор: ");
                    choose_move = in.nextByte();
                    if (choose_move == 0)
                        break;
                    if (choose_move == 1)
                        yabl.peresadka();
                    else if (choose_move == 2)
                        yabl.cvisti();
                    else if (choose_move == 3)
                        yabl.plodonocit();
                    else if (choose_move == 4)
                        yabl.padinnyaListya();
                    else if (choose_move == 5)
                        yabl.pokritisyaSnigom();
                }while(true);
            else
                do{
                    System.out.println("Выберете вкладку\n1.Пересадка;\n2.Цвести;\n3.Плодоносит;\n4.Опасть;\n5.Покрыть снегом;\n0.Exit;\nВаш выбор: ");
                    choose_move = in.nextByte();
                    if (choose_move == 0)
                        break;
                    if (choose_move == 1)
                        grusha.peresadka();
                    else if (choose_move == 2)
                        grusha.cvisti();
                    else if (choose_move == 3)
                        grusha.plodonocit();
                    else if (choose_move == 4)
                        grusha.padinnyaListya();
                    else if (choose_move == 5)
                        grusha.pokritisyaSnigom();
                }while(true);
            System.out.println("Вы хотите продолжить работу(0-нет или любое число): ");
            exit = in.nextByte();
            if(exit == 0)
                break;
        }while (true);

    }
}
