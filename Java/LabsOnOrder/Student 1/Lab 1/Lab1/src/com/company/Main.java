package com.company;
import java.lang.String;
import java.util.Scanner;
import javax.swing.*;

public class Main
{
    public static void main(String[] args) {
        double a, b, result, x;
        Scanner scan = new Scanner(System.in);

//        System.out.print("Введите х: ");
//        x = scan.nextDouble();
//        System.out.print("Введите b: ");
//        b = scan.nextDouble();
//        System.out.print("Введите a: ");
//        a = scan.nextDouble();
//        System.out.print("Исходные данные: x = "+ x + "\ta = "+ a+ "\tb = "+b);
//        result = b * Math.tan(x) - (a / Math.sin(x/a));
//        System.out.print("\nРезультат: " + result);


        x=Double.parseDouble(JOptionPane.showInputDialog("Введите x:"));
        b=Double.parseDouble(JOptionPane.showInputDialog("Введите b:"));
        a=Double.parseDouble(JOptionPane.showInputDialog("Введите a:"));
        JOptionPane.showMessageDialog(null, "Исходные данные: x = "+ x + "\ta = "+a+ "\tb = "+b, "Формула",  JOptionPane.PLAIN_MESSAGE);
        result = b * Math.tan(x) - (a / Math.sin(x/a));
        JOptionPane.showMessageDialog(null,"Ваш результат" + result,"Формула" ,  JOptionPane.PLAIN_MESSAGE);


    }
}