package com.company;
import java.lang.String;
import java.util.Scanner;
import javax.swing.*;

public class Main
{
    public static void main(String[] args) {
        double a, b, result, x;
        Scanner in = new Scanner(System.in);

//        System.out.print("Уведіть х для обчислення: ");
//        x = in.nextDouble();
//        System.out.print("Уведіть b для обчислення: ");
//        b = in.nextDouble();
//        System.out.print("Уведіть a: для обчислення: ");
//        a = in.nextDouble();
//        System.out.print("Уведенні дані: x = "+ x + "\ta = "+ a+ "\tb = "+b);
//        result = (b * Math.pow(x, 2) - a)/(Math.exp(a*x) - 1);
//        System.out.print("\nРезультат: " + result);

        x=Double.parseDouble(JOptionPane.showInputDialog("Уведіть х для обчислення:"));
        b=Double.parseDouble(JOptionPane.showInputDialog("Уведіть b для обчислення:"));
        a=Double.parseDouble(JOptionPane.showInputDialog("Уведіть a: для обчислення:"));
        JOptionPane.showMessageDialog(null, "Уведенні дані: x = "+ x + "\ta = "+a+ "\tb = "+b, "Формула",  JOptionPane.PLAIN_MESSAGE);
        result = (b * Math.pow(x, 2) - a)/(Math.exp(a*x) - 1);
        JOptionPane.showMessageDialog(null,"Ваш результат" + result,"Формула" ,  JOptionPane.PLAIN_MESSAGE);
    }
}