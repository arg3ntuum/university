
import javax.swing.*;
import javax.swing.event.ListSelectionEvent;
import javax.swing.event.ListSelectionListener;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Converter extends JInternalFrame  {
    public static int width = 600;
    public static int height = 450;
    public static Font font = new Font("Arial", Font.ITALIC, 26);
    public static final String[] Names = {
            "Миллиграммы [мг]",
            "Граммы [г]",
            "Килограммы [кг]",
            "Тонны [т]",
            "Центнеры [ц]"};

    Converter() {
        JFrame frame = new JFrame();

        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(width, height);
        frame.setLocationRelativeTo(null);

        frame.setLayout(new GridBagLayout());
        GridBagConstraints c = new GridBagConstraints();

        JLabel l1 = new JLabel("Конвертер веса:");
        l1.setFont(font);
        c.gridx = 0;
        c.gridy = 0;
        c.anchor = GridBagConstraints.NORTH;
        c.gridheight = 1;
        c.gridwidth = 2;
        c.weightx = 1.0;
        c.weighty = 0.0;
        frame.add(l1, c);

        JPanel pan1 = new JPanel();
        c.fill = GridBagConstraints.EAST;
        c.gridx = 0;
        c.gridy = 1;
        c.gridheight = 1;
        c.gridwidth = 1;
        c.weightx = 1.0;
        c.weighty = 0.5;
        pan1.setLayout(new GridLayout(1, 1));
        JLabel l_in = new JLabel("Из:");
        pan1.add(l_in);

        DefaultListModel<String> listModel1 = new DefaultListModel<>();

        for (int i = 0; i < Names.length; i++)
            listModel1.addElement(Names[i]);

        JList<String> list1 = new JList<>(listModel1);
        list1.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
        pan1.add(new JScrollPane(list1));
        frame.add(pan1, c);

        JPanel pan2 = new JPanel();
        c.gridx = 1;
        c.gridy = 1;

        pan2.setLayout(new GridLayout(1, 1));
        JLabel l_out = new JLabel("В:");
        pan2.add(l_out);

        JComboBox<String> comboBox = new JComboBox<>(Names);
        pan2.add(comboBox);
        frame.add(pan2, c);

        JPanel pan3 = new JPanel();
        pan3.setBackground(Color.WHITE);
        c.fill = GridBagConstraints.BOTH;
        c.gridx = 0;
        c.gridy = 2;
        c.gridwidth = 2;
        c.weightx = 1.0;
        c.weighty = 0.0;

        JLabel l_value = new JLabel("Значение:");
        pan3.add(l_value);
        final JTextField tf_value = new JTextField(15);
        pan3.add(tf_value);
        JLabel l_equal = new JLabel("=");
        pan3.add(l_equal);
        final JLabel l_result = new JLabel("_________");
        pan3.add(l_result);
        JButton result = new JButton("Конвертировать");
        pan3.add(result);
        JButton reset = new JButton("Сброс");
        pan3.add(reset);

        Conversion convert = new Conversion();

        list1.addListSelectionListener(new ListSelectionListener() {
            @Override
            public void valueChanged(ListSelectionEvent e) {
                if (!e.getValueIsAdjusting()) {
                    String selectedUnit1 = list1.getSelectedValue();
                    // Здесь обработайте выбор единицы веса из первой группы
                }
            }
        });

        comboBox.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String selectedUnit2 = comboBox.getSelectedItem().toString();
                // Здесь обработайте выбор единицы веса из второй группы
            }
        });

        result.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                double result = 0;
                try {
                    String inputUnit = getType(list1.getSelectedValue());
                    String outputUnit = getType(comboBox.getSelectedItem().toString());
                    result = convert.convert(inputUnit, outputUnit, Double.parseDouble(tf_value.getText()));
                    l_result.setText(Double.toString(result));
                } catch (Exception ex) {
                    l_result.setText(ex.getMessage());
                }
            }
        });


        reset.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                list1.clearSelection();
                comboBox.setSelectedIndex(0);
                tf_value.setText("");
                l_result.setText("_________");
            }
        });

        frame.add(pan3, c);
        frame.pack();
        frame.setVisible(true);
    }
    public static String getType(String type){
        switch (type)
        {
            case "Миллиграммы [мг]": return "mg";
            case "Граммы [г]": return "g";
            case "Килограммы [кг]": return "kg";
            case "Тонны [т]": return "t";
            case "Центнеры [ц]": return "c";
        }
        return "error";
    }
}
