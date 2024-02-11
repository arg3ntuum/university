import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

// Press Shift twice to open the Search Everywhere dialog and type `show whitespaces`,
// then press Enter. You can now see whitespace characters in your code.
public class ConverterPriclad extends JInternalFrame  {
    ConverterPriclad() {
        JFrame frame = new JFrame();

        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(600, 450);
        frame.setLocationRelativeTo(null);

        frame.setLayout(new GridBagLayout());
        GridBagConstraints c = new GridBagConstraints();

        JLabel l1 = new JLabel("Конвертер довжини (відстані):");
        l1.setFont(new Font("Arial", Font.ITALIC, 26));
        c.gridx = 0; c.gridy = 0;
        c.anchor = GridBagConstraints.NORTH;
        c.gridheight = 1; c.gridwidth = 2;
        c.weightx = 1.0; c.weighty = 0.0;
        frame.add(l1, c);

        JPanel pan1 = new JPanel();
        c.fill = GridBagConstraints.EAST;
        c.gridx = 0; c.gridy = 1;
        c.gridheight = 1; c.gridwidth = 1;
        c.weightx = 1.0; c.weighty = 0.5;
        pan1.setLayout(new GridLayout(6,1));
        JLabel l_in = new JLabel("З:");
        pan1.add(l_in);
        final ButtonGroup group1 = new ButtonGroup();
        JRadioButton rb1 = new JRadioButton("кілометр [км]");
        rb1.setActionCommand("km");
        JRadioButton rb2 = new JRadioButton("метр [м]");
        rb2.setActionCommand("m");
        JRadioButton rb3 = new JRadioButton("дециметр [дс]");
        rb3.setActionCommand("dc");
        JRadioButton rb4 = new JRadioButton("сантиметр [см]");
        rb4.setActionCommand("sm");
        JRadioButton rb5 = new JRadioButton("міліметр [мм]");
        rb5.setActionCommand("mm");
        group1.add(rb1);
        group1.add(rb2);
        group1.add(rb3);
        group1.add(rb4);
        group1.add(rb5);

        pan1.add(rb1);
        pan1.add(rb2);
        pan1.add(rb3);
        pan1.add(rb4);
        pan1.add(rb5);
        frame.add(pan1, c);

        JPanel pan2 = new JPanel();
        c.gridx = 1;
        c.gridy = 1;

        pan2.setLayout(new GridLayout(6,1));
        JLabel l_out = new JLabel("B:");
        pan2.add(l_out);
        final ButtonGroup group2 = new ButtonGroup();
        JRadioButton rb6 = new JRadioButton("кілометр [км]");
        rb6.setActionCommand("km");
        JRadioButton rb7 = new JRadioButton("метр [м]");
        rb7.setActionCommand("m");
        JRadioButton rb8 = new JRadioButton("дециметр [дс]");
        rb8.setActionCommand("dc");
        JRadioButton rb9 = new JRadioButton("сантиметр [см]");
        rb9.setActionCommand("sm");
        JRadioButton rb10 = new JRadioButton("міліметр [мм]");
        rb10.setActionCommand("mm");

        group2.add(rb6);
        group2.add(rb7);
        group2.add(rb8);
        group2.add(rb9);
        group2.add(rb10);

        pan2.add(rb6);
        pan2.add(rb7);
        pan2.add(rb8);
        pan2.add(rb9);
        pan2.add(rb10);
        frame.add(pan2, c);

        JPanel pan3 = new JPanel();
        pan3.setBackground(Color.WHITE);
        c.fill = GridBagConstraints.BOTH;
        c.gridx = 0; c.gridy = 2;
        c.gridwidth = 2;
        c.weightx = 1.0; c.weighty = 0.0;

        JLabel l_value = new JLabel("Значення:");
        pan3.add(l_value);
        final JTextField tf_value = new JTextField(15);
        pan3.add(tf_value);
        JLabel l_equal = new JLabel("=");
        pan3.add(l_equal);
        final JLabel l_result = new JLabel("_________");
        pan3.add(l_result);
        JButton result = new JButton("Перевести");
        pan3.add(result);
        JButton reset = new JButton("Скидання");
        pan3.add(reset);

        ConversionPriclad convert = new ConversionPriclad();
        result.addActionListener(new ActionListener(){
            @Override
            public void actionPerformed(ActionEvent e) {
                float result = 0;
                try{
                    result =
                            convert.convert(group1.getSelection().getActionCommand(),
                                    group2.getSelection().getActionCommand(),
                                    Float.parseFloat(tf_value.getText()) );
                    l_result.setText(Float.toString(result));
                }
                catch (Exception NullPointerException){
                    l_result.setText("Помилка!!!");
                }
            }});

        reset.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                group1.clearSelection();
                group2.clearSelection();
                tf_value.setText("");
                l_result.setText("_________");
            }});

        frame.add(pan3, c);
        frame.pack();
        frame.setVisible(true);
    }
}