import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Main {
    public static int width = 800;
    public static int height = 600;
    public static String[] localization = {
            "Робочий стіл",
            "Програми",
            "Вид",
            "Калькулятор",//3
            "Конвертер приклад",
            "Конвертер",
            "Таблиця",//6
            "Редактор тексту",
            "Змінити розміри вікна",
            "Введіть нову ширину:",//9
            "Введіть нову висоту:",
            "Невірний формат введених даних",
            "Помилка",//12
            "На весь єкран",
            "Змінити колір фону",
            "Вибір фону",//15
    };
    public static void main(String[] args) {
        JFrame frame = new JFrame(localization[0]);
        frame.setSize(width, height);
        frame.setLocationRelativeTo(null);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        JDesktopPane dp = new JDesktopPane();
        frame.add(dp);

        JMenuBar mb = new JMenuBar();
        JMenu program = new JMenu(localization[1]);
        JMenu view = new JMenu(localization[2]);
        JMenuItem calcul = new JMenuItem(localization[3]);
        JMenuItem converterPr = new JMenuItem(localization[4]);
        JMenuItem converter = new JMenuItem(localization[5]);
        JMenuItem table = new JMenuItem(localization[6]);
        JMenuItem redactor = new JMenuItem(localization[7]);

        program.add(calcul);
        program.add(converterPr);
        program.add(converter);
        program.add(table);
        program.add(redactor);
        // Пункт меню для зміни розмірів вікна
        JMenuItem resize = new JMenuItem(localization[8]);
        resize.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String widthInput = JOptionPane.showInputDialog(frame, localization[9]);
                String heightInput = JOptionPane.showInputDialog(frame, localization[10]);
                try {
                    int newWidth = Integer.parseInt(widthInput);
                    int newHeight = Integer.parseInt(heightInput);
                    frame.setSize(newWidth, newHeight);
                } catch (NumberFormatException ex) {
                    JOptionPane.showMessageDialog(frame, localization[11], localization[12], JOptionPane.ERROR_MESSAGE);
                }
            }
        });
        view.add(resize);

        JCheckBoxMenuItem fullScreen = new JCheckBoxMenuItem(localization[13]);
        JMenuItem background = new JMenuItem(localization[14]);
        view.add(fullScreen);
        view.add(background);
        mb.add(program);
        mb.add(view);
        frame.setJMenuBar(mb);
        frame.setVisible(true);

        background.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                Color newColor = JColorChooser.showDialog(null, localization[15], Color.yellow);
                dp.setBackground(newColor);
            }
        });

        calcul.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                calcFrame cc = new calcFrame();
                dp.add(cc);
                cc.setVisible(true);
            }
        });
        converterPr.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                ConverterPriclad cv = new ConverterPriclad();
                dp.add(cv);
                cv.setVisible(true);
            }
        });
        converter.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                Converter cv = new Converter();
                dp.add(cv);
                cv.setVisible(true);
            }
        });
        table.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                Table tb = new Table();
                dp.add(tb);
                tb.setVisible(true);
            }
        });
        redactor.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                Redactor rd = new Redactor();
                dp.add(rd);
                rd.setVisible(true);
            }
        });
    }
}
