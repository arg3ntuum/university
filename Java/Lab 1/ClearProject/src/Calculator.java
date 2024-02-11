import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Collection;
import java.util.Iterator;
import java.util.List;
import java.util.ListIterator;

public class Calculator {
    public static void main(String[] args) {
        int width = 51;
        int height = 30;
        int margin = 5;
        int margin_buttons = 3;


        JFrame frame = new JFrame("Calculator/Sheyko. KI-21-2");
        frame.setLayout(null);
        frame.setSize(width * 9 + 10, height * 7);
        frame.setLocationRelativeTo(null);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setResizable(false);

        JTextField tf1 = new JTextField(20);
        tf1.setEditable(false);
        tf1.setBounds(5,5,frame.getWidth() - 5 * margin,25);
        frame.add(tf1);

        JTextArea history = new JTextArea();
        history.setWrapStyleWord(true); // Перенос слов
        history.setLineWrap(true); // Перенос строк
        history.setEditable(false);
        JScrollPane scrollPane = new JScrollPane(history);
        scrollPane.setBounds(6 * width + 8 * margin_buttons,40,2 * width + margin_buttons, height * 3 + 2 * margin_buttons);
        history.setText("  Історія операцій:");
        frame.add(scrollPane);

        ////
        //buttons numpad
        ////
        JButton b0 = new JButton("0");
        b0.setBounds(margin + width + 3, 139, width, height);
        frame.add(b0);

        JButton b1 = new JButton("1");
        b1.setBounds(margin, 40, width, height);
        frame.add(b1);

        JButton b2 = new JButton("2");
        b2.setBounds(margin + width + 3, 40, width, height);
        frame.add(b2);

        JButton b3 = new JButton("3");
        b3.setBounds(margin + width + margin_buttons + width + margin_buttons, 40, width, height);
        frame.add(b3);

        JButton b4 = new JButton("4");
        b4.setBounds(margin, 40 + height + margin_buttons, width, height);
        frame.add(b4);

        JButton b5 = new JButton("5");
        b5.setBounds(margin + width + 3, 40 + height + margin_buttons, width, height);
        frame.add(b5);

        JButton b6 = new JButton("6");
        b6.setBounds(margin + width + margin_buttons + width + margin_buttons, 40 + height + margin_buttons , width, height);
        frame.add(b6);

        JButton b7 = new JButton("7");
        b7.setBounds(margin, 40 + height + margin_buttons + height + margin_buttons, width, height);
        frame.add(b7);

        JButton b8 = new JButton("8");
        b8.setBounds(margin + width + 3, 40 + height + margin_buttons + height + margin_buttons, width, height);
        frame.add(b8);

        JButton b9 = new JButton("9");
        b9.setBounds(margin + width + margin_buttons + width + margin_buttons, 40 + height + margin_buttons + height + margin_buttons, width, height);
        frame.add(b9);

        ////
        //memory
        ////
        JButton bmr = new JButton("mr");
        bmr.setBounds( 5* width + 7 * margin_buttons, 40 + 3 * height + 3 * margin_buttons, width, height);
        frame.add(bmr);

        JButton bms = new JButton("ms");
        bms.setBounds( 4* width + 6 * margin_buttons, 40 + 3 * height + 3 * margin_buttons, width, height);
        frame.add(bms);

        JButton bmc = new JButton("mc");
        bmc.setBounds( 3* width + 5 * margin_buttons, 40 + 3 * height + 3 * margin_buttons, width, height);
        frame.add(bmc);

        JButton bplus = new JButton("m+");
        bplus.setBounds( 6* width + 8 * margin_buttons, 40 + 3 * height + 3 * margin_buttons, width, height);
        frame.add(bplus);

        JButton bminus = new JButton("m-");
        bminus.setBounds( 7* width + 9 * margin_buttons, 40 + 3 * height + 3 * margin_buttons, width, height);
        frame.add(bminus);

        ////
        //operations
        ////
        JButton badd = new JButton("+");
        badd.setBounds(3 * width + 5 * margin_buttons, 40, width, height);
        frame.add(badd);

        JButton bmult = new JButton("*");
        bmult.setBounds(4 * width + 6 * margin_buttons, 40, width, height);
        frame.add(bmult);

        JButton bmin = new JButton("-");
        bmin.setBounds(5 * width + 7 * margin_buttons, 40, width, height);
        frame.add(bmin);

        JButton bdot = new JButton(".");
        bdot.setBounds(3 * width + 5 * margin_buttons, 40 + height + margin_buttons, width, height);
        frame.add(bdot);

        JButton bcl = new JButton("C");
        bcl.setBounds(4 * width + 6 * margin_buttons, 40 + height + margin_buttons, width, height);
        frame.add(bcl);

        JButton bdiv = new JButton("/");
        bdiv.setBounds(5 * width + 7 * margin_buttons, 40 + height + margin_buttons, width, height);
        frame.add(bdiv);

        JButton bexp = new JButton("^");
        bexp.setBounds(5 * width + 7 * margin_buttons, 40 + height + margin_buttons + height + margin_buttons, width, height);
        frame.add(bexp);

        JButton beq = new JButton("=");
        beq.setBounds(3 * width + 5 * margin_buttons, 106, 2 * width + margin_buttons, height);
        frame.add(beq);
// ...
        //JLabel l1 = new JLabel("Sheyko, №KI-21-2");
        //l1.setBounds(5 * width + 7 * margin_buttons,139,170,40);
        //frame.add(l1);
        frame.setVisible(true);

        Calculation c = new Calculation();

        b0.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                String temp = tf1.getText();
                tf1.setText(temp + '0'); }});
        b1.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                String temp = tf1.getText();
                tf1.setText(temp + '1'); }});
        b2.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                String temp = tf1.getText();
                tf1.setText(temp + '2'); }});
        b3.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                String temp = tf1.getText();
                tf1.setText(temp + '3'); }});
        b4.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                String temp = tf1.getText();
                tf1.setText(temp + '4'); }});
        b5.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                String temp = tf1.getText();
                tf1.setText(temp + '5'); }});
        b6.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                String temp = tf1.getText();
                tf1.setText(temp + '6'); }});
        b7.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                String temp = tf1.getText();
                tf1.setText(temp + '7'); }});
        b8.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                String temp = tf1.getText();
                tf1.setText(temp + '8'); }});
        b9.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                String temp = tf1.getText();
                tf1.setText(temp + '9'); }});
// ...
        /////
        //bmemory
        ////
        bmc.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                c.mc();
            } });
        bminus.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                c.mm();
                tf1.setText("" + c.getData());}});
        bplus.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                c.mp();
                tf1.setText("" + c.getData());}});
        bmr.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                c.mr();
                tf1.setText("" + c.getData());}});
        bms.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                c.ms();
               }});
        //////
        //bfunc
        //////
        bdot.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                if(tf1.getText().trim().length() > 0){
                    String temp = tf1.getText();
                    tf1.setText(temp + '.');
                    bdot.setEnabled(false);
                }} });
        badd.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                c.add(Float.parseFloat(tf1.getText()));
                tf1.setText("");
                bdot.setEnabled(true);
            } });
        bmult.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                c.mult(Float.parseFloat(tf1.getText()));
                tf1.setText("");
                bdot.setEnabled(true);
            } });
        bmin.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                c.min(Float.parseFloat(tf1.getText()));
                tf1.setText("");
                bdot.setEnabled(true);
            } });
        bdiv.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                c.div(Float.parseFloat(tf1.getText()));
                tf1.setText("");
                bdot.setEnabled(true);
            } });
        bexp.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                c.exp(Float.parseFloat(tf1.getText()));
                tf1.setText("");
                bdot.setEnabled(true);
            } });
// ...
        beq.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                tf1.setText(Float.toString(c.equal(Float.parseFloat(tf1.getText()))));
                history.setText(history.getText() + c.getHistory());
            } });
        bcl.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e) {
                c.clear();
                tf1.setText("");
                bdot.setEnabled(true);}});



    }
}