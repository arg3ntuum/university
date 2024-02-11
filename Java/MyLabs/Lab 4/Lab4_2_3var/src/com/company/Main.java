package com.company;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        byte delayu = 0;
        int choose = 0, course1 = 0, choose_pers = 0, choose_uprav;
        String name_1, name_2;
        Scanner in = new Scanner(System.in);
        Shkolyar shk = new Shkolyar("Vitya", "Archipov", 11);
        Student std = new Student("Grisha", "Gogynskiy", 3);


        System.out.println("Здравствуйте! Это история про ваших персонажей. "
                + "Давайте создадим двух персонажей. Первый будет школьником, а второй студентом. " );
        do {
            System.out.println("Выберите способ создания персонажей (1 - процедурный, 2 - ручной): ");
            choose = in.nextInt();
            if (choose == 1 )
                break;
            else if(choose == 2)
            {
                System.out.println("Создадим школьника!");
                System.out.print("Введите имя:");
                name_1 = in.next();
                System.out.print("Введите фамилию:");
                name_2 = in.next();
                System.out.print("Введите класс:");
                course1 = in.nextInt();
                shk = new Shkolyar(name_1, name_2, course1);//Shkolyar shk = new Shkolyar(name_1, name_2, course1);

                System.out.println("Создадим студента!");
                System.out.print("Введите имя:");
                name_1 = in.next();
                System.out.print("Введите фамилию:");
                name_2 = in.next();
                System.out.print("Введите курс:");
                course1 = in.nextInt();
                std = new Student(name_1, name_2, course1);//Student std = new Student(name_1, name_2, course1);
                break;
            }
            else System.out.println("Введите корректные данные!");
        } while(true);

        System.out.println("У вас есть два сына, один школьник " + shk.Firstname + " " + shk.Lastname+
                ". Он учится в " + shk.clas + " классе. Также у меня сын " + std.Firstname+ " " + std.Lastname+
                ". Он учится на " + std.course + " курсе.");

        System.out.println("Предлагаю вам освоить поле управления персонажами.");
        do {
            System.out.print("Выберите персонажа:\n1.Школьник;\n2.Студент;\n0.EXIT\nВаш выбор: ");
            choose_pers = in.nextInt();
            if (choose_pers == 0)
                break;
            else if (choose_pers == 1)
            {
                do {
                    System.out.print("Управление вашим персонажем:\n1.Бегать на физре\n2.Делать уроки\n0.EXIT\nВаш выбор: ");
                    choose_uprav = in.nextInt();
                    if (choose_uprav == 0)
                        break;
                    else if(choose_uprav == 1) {
                        shk.bigati();
                    }
                    else if  (choose_uprav == 2) {
                        if(delayu == 0)
                        System.out.println("На данный момент " + shk.Firstname + " отдыхает.");
                        else System.out.println("На данный момент " + shk.Firstname + " делает уроки.");
                        delayu = shk.robutu_uroki();
                    }
                    else System.out.println("Введите корректные данные!");
                } while(true);
            }
            else if (choose_pers == 2) {
                do {
                    System.out.print("Управление вашим персонажем:\n1.Бегать на физре\n2.Делать уроки\n0.EXIT\nВаш выбор: ");
                    choose_uprav = in.nextInt();
                    if (choose_uprav == 0)
                        break;
                    else if(choose_uprav == 1) {
                        std.bigati();
                    }
                    else if  (choose_uprav == 2) {
                        if(delayu == 0)
                            System.out.println("На данный момент " + std.Firstname + " отдыхает.");
                        else System.out.println("На данный момент " + std.Firstname + " делает уроки.");
                        delayu = std.robutu_uroki();
                    }
                    else System.out.println("Введите корректные данные!");
                } while(true);
            }
            else System.out.println("Введите корректные данные!");
        } while(true);
    }
}
