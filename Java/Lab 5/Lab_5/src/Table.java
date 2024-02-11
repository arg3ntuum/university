import javax.swing.*;
import javax.swing.JFormattedTextField;
import javax.swing.text.NumberFormatter;
import javax.swing.table.TableRowSorter;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.text.NumberFormat;

public class Table extends JMenuItem{
    public static int width = 800;
    public static int height = 600;
    public static Font font = new Font("Arial", Font.BOLD, 16);
    public static int columnNumber = 15;
    public static int[] columnWidth = {
            50, 200, 120, 120, 200
    };
    public static String[] localizationUA = {
            "Додавання даних",
            "Додати",
            "ПІБ",
            "№ студ.",        //3
            "Контактні дані",
            "Група",
            "Фільтр:",        //6
            "Фільтрувати",
            "Видалити рядок",
            "Редагувати",  //9
            "Закінчити редагування",

    };
    Table() {
        JFrame frame = new JFrame();
        frame.setSize(width, height);
        frame.setLocationRelativeTo(null);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        frame.setLayout(new GridBagLayout());
        GridBagConstraints c = new GridBagConstraints();

        TableModel tm = new TableModel();
        JTable t1 = new JTable(tm);
        DefaultCellEditor cellEditor = new DefaultCellEditor(new JTextField());
        t1.setDefaultEditor(Object.class, cellEditor);

        t1.setAutoResizeMode(JTable.AUTO_RESIZE_OFF);
        for(int i = 0; i < columnWidth.length; i++)
            t1.getColumnModel().getColumn(i).setPreferredWidth(columnWidth[i]);

        JScrollPane scrollPane = new JScrollPane(t1);
        scrollPane.setPreferredSize(new Dimension(t1.getPreferredSize().width, 400));
        c.gridx = 0;
        c.gridy = 0;
        c.gridwidth = 1;
        c.gridheight = 2;
        c.fill = GridBagConstraints.BOTH;
        frame.add(scrollPane, c);

        JPanel panel1 = new JPanel();
        JLabel panel_name = new JLabel(localizationUA[0]);
        panel_name.setFont(font);
        panel1.setLayout(new GridBagLayout());
        JButton add_data = new JButton(localizationUA[1]);
        JLabel fio_lab = new JLabel(localizationUA[2]);
        final JTextField fio_tf = new JTextField(columnNumber);
        JLabel id_lab = new JLabel(localizationUA[3]);
        NumberFormatter formatter = new NumberFormatter(NumberFormat.getIntegerInstance());
        formatter.setValueClass(Integer.class); // Укажите класс значений (в данном случае Integer)
        formatter.setMinimum(0); // Минимальное значение
        formatter.setMaximum(Integer.MAX_VALUE); // Максимальное значение
        JFormattedTextField id_tf = new JFormattedTextField(formatter);
        id_tf.setColumns(columnNumber);
        JLabel number_lab = new JLabel(localizationUA[4]);
        final JTextField number_tf = new JTextField(columnNumber);
        JLabel group_lab = new JLabel(localizationUA[5]);
        final JTextField group_tf = new JTextField(columnNumber);

        // Додайте фільтраційну панель
        JPanel filterPanel = new JPanel();
        JLabel filterLabel = new JLabel(localizationUA[6]);
        JComboBox<String> filterColumn = new JComboBox<>(tm.getColumnNames());
        JTextField filterText = new JTextField(columnNumber);
        JButton filterButton = new JButton(localizationUA[7]);

        filterPanel.add(filterLabel);
        filterPanel.add(filterColumn);
        filterPanel.add(filterText);
        filterPanel.add(filterButton);

        c.gridx = 0;
        c.gridy = 2;
        c.gridwidth = 1;
        frame.add(filterPanel, c);

        // Створіть фільтрувальник для таблиці
        DefaultRowSorter<TableModel, Integer> sorter = new TableRowSorter<>(tm);
        t1.setRowSorter(sorter);

        filterButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String selectedColumn = filterColumn.getSelectedItem().toString();
                String filterValue = filterText.getText();
                sorter.setRowFilter(RowFilter.regexFilter(filterValue, tm.getColumnIndexByName(selectedColumn)));
            }
        });

        c.gridwidth = 1;
        c.gridheight = 1;
        c.fill = GridBagConstraints.HORIZONTAL;

        c.gridwidth = 2;
        c.gridx = 0;
        c.gridy = 0;
        panel1.add(panel_name, c);
        c.gridwidth = 1;
        c.gridx = 0;
        c.gridy = 1;
        c.anchor = GridBagConstraints.NORTH;
        panel1.add(fio_lab, c);
        c.gridx = 1;
        c.gridy = 1;
        panel1.add(fio_tf, c);

        c.gridx = 0;
        c.gridy = 2;
        panel1.add(id_lab, c);
        c.gridx = 1;
        c.gridy = 2;
        panel1.add(id_tf, c);

        c.gridx = 0;
        c.gridy = 3;
        panel1.add(group_lab, c);
        c.gridx = 1;
        c.gridy = 3;
        panel1.add(group_tf, c);

        c.gridx = 0;
        c.gridy = 4;
        panel1.add(number_lab, c);
        c.gridx = 1;
        c.gridy = 4;
        panel1.add(number_tf, c);

        c.gridx = 0;
        c.gridy = 5;
        c.gridwidth = 2;
        panel1.add(add_data, c);

        c.gridx = 1;
        c.gridy = 0;
        c.gridwidth = 1;
        frame.add(panel1, c);

        JButton select_remove = new JButton(localizationUA[8]);
        c.gridx = 1;
        c.gridy = 1;
        c.gridwidth = 1;
        c.gridheight = 1;
        frame.add(select_remove, c);

        add_data.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String[] st = {Integer.toString(tm.getRowCount() + 1),
                        fio_tf.getText(), id_tf.getText(), group_tf.getText(), number_tf.getText()};
                tm.addData(st);
                fio_tf.setText("");
                id_tf.setText("");
                group_tf.setText("");
                number_tf.setText("");
                t1.revalidate();
                t1.repaint();
            }
        });

        final boolean[] editMode = {false}; // Declare as an array to make it effectively final

        JButton editButton = new JButton(localizationUA[9]);
        c.gridx = 1;
        c.gridy = 2;
        frame.add(editButton, c);

        editButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                editMode[0] = !editMode[0];
                if (editMode[0]) {
                    t1.setEnabled(true);
                    editButton.setText(localizationUA[10]);
                } else {
                    t1.setEnabled(false);
                    editButton.setText(localizationUA[9]);
                }
            }
        });

// Rest of the code remains the same


// Добавьте слушатель для редактирования данных в таблице
        t1.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                if (editMode[0] && e.getClickCount() == 2) {
                    int selectedRow = t1.getSelectedRow();
                    int selectedColumn = t1.getSelectedColumn();
                    if (selectedRow != -1 && selectedColumn != -1) {
                        t1.editCellAt(selectedRow, selectedColumn);
                        t1.getEditorComponent().requestFocus();
                    }
                }
            }
        });


        select_remove.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                int selectedRow = t1.getSelectedRow();
                if (selectedRow != -1) {
                    int modelRow = t1.convertRowIndexToModel(selectedRow);
                    tm.removeRow(modelRow);
                    tm.fireTableDataChanged(); // Обновить таблицу
                }
            }
        });

        t1.setRowSelectionAllowed(false);
        t1.setColumnSelectionAllowed(false);
        t1.setCellSelectionEnabled(true);

        frame.pack();
        frame.setVisible(true);
    }
}