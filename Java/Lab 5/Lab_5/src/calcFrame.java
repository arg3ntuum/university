import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class calcFrame extends JInternalFrame {
    JTextField tf1;
    String currentInput = "";
    double currentResult = 0.0;
    String operation = "";

    calcFrame() {
        setBackground(Color.LIGHT_GRAY);
        setTitle("Калькулятор з роботи № 1");
        setBounds(10, 10, 260, 210);
        setClosable(true);
        setResizable(false);
        setLayout(new GridBagLayout());
        GridBagConstraints gc = new GridBagConstraints();

        tf1 = new JTextField(20);
        tf1.setEditable(false);

        // Создаем кнопки цифр
        JButton[] digitButtons = new JButton[10];
        for (int i = 0; i < 10; i++) {
            digitButtons[i] = new JButton(Integer.toString(i));
        }

        // Создаем кнопки операций
        JButton badd = new JButton("+");
        JButton bsub = new JButton("-");
        JButton bmult = new JButton("*");
        JButton bdiv = new JButton("/");
        JButton beq = new JButton("=");
        JButton bdot = new JButton(".");
        JButton bcl = new JButton("C");
        JButton bbackspace = new JButton("←");

        // Размещаем элементы на панели
        gc.fill = GridBagConstraints.BOTH;
        gc.gridwidth = 5;
        gc.gridx = 0;
        gc.gridy = 0;
        add(tf1, gc);

        gc.gridwidth = 1;
        for (int i = 0; i < 10; i++) {
            int row = 1 + i / 3;
            int col = i % 3;
            gc.gridx = col;
            gc.gridy = row;
            add(digitButtons[i], gc);

            final int digit = i;
            digitButtons[i].addActionListener(new ActionListener() {
                public void actionPerformed(ActionEvent e) {
                    currentInput += digit;
                    tf1.setText(currentInput);
                }
            });
        }

        gc.gridx = 3;
        gc.gridy = 1;
        add(badd, gc);

        gc.gridx = 4;
        gc.gridy = 1;
        add(bsub, gc);

        gc.gridx = 3;
        gc.gridy = 2;
        add(bmult, gc);

        gc.gridx = 4;
        gc.gridy = 2;
        add(bdiv, gc);

        gc.gridx = 3;
        gc.gridy = 3;
        add(bdot, gc);

        gc.gridx = 4;
        gc.gridy = 3;
        add(bbackspace, gc);

        gc.gridx = 3;
        gc.gridy = 4;
        add(bcl, gc);

        gc.gridwidth = 2;
        gc.gridx = 4;
        gc.gridy = 4;
        add(beq, gc);

        // Добавляем обработчики для кнопок операций
        badd.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                performOperation();
                operation = "+";
            }
        });

        bsub.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                performOperation();
                operation = "-";
            }
        });

        bmult.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                performOperation();
                operation = "*";
            }
        });

        bdiv.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                performOperation();
                operation = "/";
            }
        });

        beq.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                performOperation();
                operation = "";
            }
        });

        bdot.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                if (!currentInput.contains(".")) {
                    currentInput += ".";
                    tf1.setText(currentInput);
                }
            }
        });

        bcl.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                currentInput = "";
                operation = "";
                currentResult = 0.0;
                tf1.setText("");
            }
        });

        bbackspace.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                if (!currentInput.isEmpty()) {
                    currentInput = currentInput.substring(0, currentInput.length() - 1);
                    tf1.setText(currentInput);
                }
            }
        });
    }

    // Метод для выполнения операции
    private void performOperation() {
        if (!currentInput.isEmpty()) {
            double operand = Double.parseDouble(currentInput);
            if (operation.equals("+")) {
                currentResult += operand;
            } else if (operation.equals("-")) {
                currentResult -= operand;
            } else if (operation.equals("*")) {
                currentResult *= operand;
            } else if (operation.equals("/")) {
                if (operand != 0) {
                    currentResult /= operand;
                } else {
                    tf1.setText("Ошибка");
                    return;
                }
            }
            tf1.setText(Double.toString(currentResult));
            currentInput = "";
        }
    }
}
