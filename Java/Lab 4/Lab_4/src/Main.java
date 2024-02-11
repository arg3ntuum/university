import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.io.*;
import javax.swing.JSpinner;
import javax.swing.SpinnerModel;
import javax.swing.SpinnerNumberModel;
import javax.swing.filechooser.FileNameExtensionFilter;


public class Main {
    public static int width = 400;
    public static int height = 250;
    public static String[] localization = {
            "Редактор текста",
            "Файл",
            "Відкрити",
            "Зберегти",//3
            "Закрити",
            "Вид",
            "Зафіксувати розмір вікна",//6
            "Повний екран",
            "Правка",
            "Копіювати",//9
            "Вставити",
            "Вирізати",
            "Стиль тексту",//12
            "Нормальний",
            "Жирний",
            "Курсив",//15
            "Колір",
            "Зберігти файл",
            "Вибір кольору тексту",//18
            "Відкрити файл",
    };
    public static void main(String[] args) {
        JFrame frame = new JFrame(localization[0]);
        frame.setSize(width, height);

        frame.setLocationRelativeTo(null);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        JMenuBar menubar = new JMenuBar();
        JMenu file = new JMenu(localization[1]);
        JMenuItem open = new JMenuItem(localization[2]);
        file.add(open);
        open.setAccelerator(KeyStroke.getKeyStroke(KeyEvent.VK_O,
                Event.CTRL_MASK));
        JMenuItem save = new JMenuItem(localization[3]);
        file.add(save);
        save.setAccelerator(KeyStroke.getKeyStroke(KeyEvent.VK_S,
                Event.CTRL_MASK));
        file.addSeparator();
        JMenuItem close = new JMenuItem(localization[4]);
        file.add(close);
        close.setAccelerator(KeyStroke.getKeyStroke(KeyEvent.VK_C,
                Event.CTRL_MASK));
        JMenu view = new JMenu(localization[5]);
        JCheckBoxMenuItem resizable = new JCheckBoxMenuItem(localization[6]);
        view.add(resizable);
        JCheckBoxMenuItem fullScreen = new JCheckBoxMenuItem(localization[7]);
                view.add(fullScreen);
        fullScreen.setAccelerator(KeyStroke.getKeyStroke(KeyEvent.VK_ENTER, Event.ALT_MASK));
        JMenu edit = new JMenu(localization[8]);
        JMenuItem copy = new JMenuItem(localization[9]);
        edit.add(copy);

        JMenuItem paste = new JMenuItem(localization[10]);
        edit.add(paste);
        JMenuItem cut = new JMenuItem(localization[11]);
        edit.add(cut);
        cut.setAccelerator(KeyStroke.getKeyStroke(KeyEvent.VK_X, Event.CTRL_MASK));

        JMenu textStyle = new JMenu(localization[12]);
        edit.add(textStyle);
        JMenuItem normalStyle = new JMenuItem(localization[13]);
        textStyle.add(normalStyle);
        JMenuItem boldStyle = new JMenuItem(localization[14]);
        textStyle.add(boldStyle);
        JMenuItem italicStyle = new JMenuItem(localization[15]);
        textStyle.add(italicStyle);
        JToolBar toolBar = new JToolBar();

// Додайте JComboBox для вибору шрифту
        String[] fontNames = GraphicsEnvironment.getLocalGraphicsEnvironment().getAvailableFontFamilyNames();
        JComboBox<String> fontComboBox = new JComboBox<>(fontNames);
        toolBar.add(fontComboBox);

// Додайте JTextField для введення розміру тексту
        JTextField fontSizeField = new JTextField("12", 4);
        toolBar.add(fontSizeField);

// Додайте кнопку для вибору кольору тексту
        JButton colorButton = new JButton(localization[16]);
        toolBar.add(colorButton);

        menubar.add(file);
        menubar.add(view);
        menubar.add(edit);

        JEditorPane ep = new JEditorPane();
        JScrollPane scrollPane = new JScrollPane(ep);
        frame.add(scrollPane);
        frame.setJMenuBar(menubar);
        frame.setVisible(true);

        JFileChooser fc_save = new JFileChooser(new File("d:\\"));
        fc_save.setDialogTitle(localization[17]);

        FileTypeFilter fileFilter1 = new FileTypeFilter(".txt", "Текстовий файл");
        FileTypeFilter fileFilter2 = new FileTypeFilter(".log", "Log-файл");
        fc_save.addChoosableFileFilter(fileFilter1);
        fc_save.addChoosableFileFilter(fileFilter2);

        fontComboBox.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String selectedFont = (String) fontComboBox.getSelectedItem();
                ep.setFont(new Font(selectedFont, Font.PLAIN, Integer.parseInt(fontSizeField.getText())));
            }
        });
        fontSizeField.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String selectedFont = (String) fontComboBox.getSelectedItem();
                ep.setFont(new Font(selectedFont, Font.PLAIN, Integer.parseInt(fontSizeField.getText())));
            }
        });
        colorButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                Color textColor = JColorChooser.showDialog(frame, localization[18], Color.BLACK);
                ep.setForeground(textColor);
            }
        });


        save.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
// ȼɢɤɨɪɢɫɬɚɬɢ ɧɚɜɟɞɟɧɿ ɜɢɳɟ ɮɪɚɝɦɟɧɬɢ ɤɨɞɭ:
// 1. ɋɬɜɨɪɢɬɢ ɨɛ'єɤɬ ɤɥɚɫɭ JFileChooser ɿ ɜɤɚɡɚɬɢ ɡɚɝɨɥɨɜɨɤ
// 2. Ⱦɨɞɚɬɢ ɮɿɥьɬɪɢ
                int result = fc_save.showSaveDialog(null);
                if (result == JFileChooser.APPROVE_OPTION){
                    String content = ep.getText();
                    File fi = fc_save.getSelectedFile();
                    try {
                        FileWriter fw = new FileWriter(fi.getPath() +
                                fc_save.getFileFilter().getDescription());
                        fw.write(content);
                        fw.flush();
                        fw.close();
                    } catch (IOException ex) {
                        JOptionPane.showMessageDialog(null,
                                ex.getMessage());}}}});
        open.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
// 1. ɋɬɜɨɪɢɬɢ ɨɛ'єɤɬ ɤɥɚɫɭ JFileChooser ɿ ɜɤɚɡɚɬɢ ɡɚɝɨɥɨɜɨɤ
// 2. Ⱦɨɞɚɬɢ ɮɿɥьɬɪɢ
                JFileChooser fc_open = new JFileChooser(new File("d:\\"));
                fc_open.setDialogTitle(localization[19]);
                fc_open.addChoosableFileFilter(fileFilter1);
                fc_open.addChoosableFileFilter(fileFilter2);
// Створіть модель для JSpinner зі значеннями від 1 до 100 та початковим значенням 12
                SpinnerModel spinnerModel = new SpinnerNumberModel(12, 1, 100, 1);
                JSpinner fontSizeSpinner = new JSpinner(spinnerModel);

// Додайте JSpinner до JToolBar
                toolBar.add(fontSizeSpinner);

// Створіть фільтр для відкриття та збереження файлів з розширенням .txt
                FileNameExtensionFilter txtFilter = new FileNameExtensionFilter("Текстові файли (*.txt)", "txt");
                fc_save.setFileFilter(txtFilter);
                JEditorPane ep = new JEditorPane();
                JScrollPane scrollPane = new JScrollPane(ep);
                frame.add(scrollPane);

// Встановіть стандартний фільтр для відкриття файлів
                fc_open.setFileFilter(txtFilter);
                int result = fc_open.showOpenDialog(null);
                if (result == JFileChooser.APPROVE_OPTION) {
                    try {File fi = fc_open.getSelectedFile();
                        BufferedReader br = new BufferedReader(new
                                FileReader(fi.getPath()));
                        String line = "";
                        StringBuilder cont = new StringBuilder();
                        while ((line = br.readLine()) != null){
                            cont.append(line);
                        }
                        ep.setText(cont.toString());
                        if (br != null) br.close();
                    } catch (Exception ex) {
                        JOptionPane.showMessageDialog(null, ex.getMessage());
                    }}}});
        close.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                System.exit(0);
            }});
        resizable.addItemListener(new ItemListener(){
            public void itemStateChanged(ItemEvent e){
                if (e.getStateChange() == ItemEvent.SELECTED) {
                    frame.setResizable(false);
                    fullScreen.setVisible(false);
                }else {
                    frame.setResizable(true);
                    fullScreen.setVisible(true);
                }
            }});
        fullScreen.addItemListener(new ItemListener(){
            public void itemStateChanged(ItemEvent e){
                if (e.getStateChange() == ItemEvent.SELECTED)
                    frame.setExtendedState(JFrame.MAXIMIZED_BOTH);
                else frame.setExtendedState(JFrame.NORMAL);
            }});
        copy.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                ep.copy();}});
        paste.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                ep.paste();
            }});
        JPopupMenu jp_menu = new JPopupMenu();

        JMenuItem copyContext = new JMenuItem(localization[9]);
        jp_menu.add(copyContext);
        JMenuItem pasteContext = new JMenuItem(localization[10]);
        jp_menu.add(pasteContext);
        JMenuItem cutContext = new JMenuItem(localization[11]);
        jp_menu.add(cutContext);
        ep.setComponentPopupMenu(jp_menu);
        cutContext.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                ep.cut();
            }
        });
        ep.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseReleased(MouseEvent evt) {
                if (evt.isPopupTrigger()) {
                    jp_menu.show(evt.getComponent(), evt.getX(), evt.getY());
                }}});
        frame.setVisible(true);
        copyContext.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                ep.copy();
            }
        });

        pasteContext.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                ep.paste();
            }
        });
        cut.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                ep.cut();
            }
        });

        normalStyle.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                // Застосовуйте стиль "Нормальний" до тексту
                ep.setFont(ep.getFont().deriveFont(Font.PLAIN));
            }
        });

        boldStyle.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                // Застосовуйте стиль "Жирний" до тексту
                ep.setFont(ep.getFont().deriveFont(Font.BOLD));
            }
        });

        italicStyle.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                // Застосовуйте стиль "Курсив" до тексту
                ep.setFont(ep.getFont().deriveFont(Font.ITALIC));
            }
        });

        frame.add(toolBar, BorderLayout.NORTH);

    }
}