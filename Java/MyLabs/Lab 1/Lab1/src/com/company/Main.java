package com.company;
import java.lang.String;
import java.util.Scanner;
import javax.swing.*;

public class Main
{
    public static void main(String[] args) {
        double result, x, y;
        //Scanner scan = new Scanner(System.in);

        //System.out.print("Введите х: ");
        //x = scan.nextInt();
        //System.out.print("Введите у: ");
        //y = scan.nextInt();

        x=Double.parseDouble(JOptionPane.showInputDialog("Введите x:"));
        y=Double.parseDouble(JOptionPane.showInputDialog("Введите у:"));

        JOptionPane.showMessageDialog(null, "Исходные данные: x = "+ x + "\ty = " +y, "Формула",  JOptionPane.PLAIN_MESSAGE);
        //System.out.print("Исходные данные: x = "+ x + "\ty = "+y);
        result = (Math.pow(x, y) - Math.cbrt(x/y));
        //System.out.print("\nРезультат: " + result);
        JOptionPane.showMessageDialog(null,"Ваш результат" + result,"Формула" ,  JOptionPane.PLAIN_MESSAGE);
    }
}