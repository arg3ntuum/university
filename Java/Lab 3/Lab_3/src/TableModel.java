import javax.swing.table.AbstractTableModel;
import java.util.ArrayList;
import javax.swing.RowFilter;

public class TableModel extends AbstractTableModel {

    protected ArrayList<String[]> data;
    protected int columnCount = 5;

    public TableModel() {
        data = new ArrayList<String[]>();
    }

    @Override
    public int getRowCount() {
        return data.size();
    }

    @Override
    public int getColumnCount() {
        return columnCount;
    }

    @Override
    public Object getValueAt(int rowIndex, int columnIndex) {
        String[] row = data.get(rowIndex);
        return row[columnIndex];
    }

    // Добавьте следующий метод для разрешения редактирования ячейки
    @Override
    public boolean isCellEditable(int rowIndex, int columnIndex) {
        // Возвращайте true только для тех столбцов, которые вы хотите разрешить редактировать.
        return columnIndex != 0; // Например, не разрешайте редактировать столбец "№"
    }

    // Добавьте следующий метод для сохранения изменений в ячейке
    @Override
    public void setValueAt(Object value, int rowIndex, int columnIndex) {
        String[] row = data.get(rowIndex);
        row[columnIndex] = value.toString();
        fireTableCellUpdated(rowIndex, columnIndex);
    }

    public void removeRow(int rowIndex) {
        if (rowIndex >= 0 && rowIndex < data.size()) {
            data.remove(rowIndex);
            fireTableRowsDeleted(rowIndex, rowIndex);
            changeNumbers(rowIndex);
        }
    }

    public void addData(String[] row) {
        data.add(row);
        fireTableDataChanged();
    }

    public String getColumnName(int columnIndex) {
        switch (columnIndex) {
            case 0:
                return "№";
            case 1:
                return Main.localizationUA[2];
            case 2:
                return Main.localizationUA[3];
            case 3:
                return Main.localizationUA[5];
            case 4:
                return Main.localizationUA[4];
        }
        return "";
    }

    public void changeNumbers(int rowDeleteIndex) {
        for (int i = rowDeleteIndex; i < data.size(); i++) {
            String currentId = data.get(i)[0];
            data.get(i)[0] = Integer.toString(i + 1);
        }
    }

    public int getColumnIndexByName(String columnName) {
        for (int i = 0; i < getColumnCount(); i++) {
            if (getColumnName(i).equals(columnName)) {
                return i;
            }
        }
        return -1;
    }
    public String[] getColumnNames() {
        String[] columnNames = new String[getColumnCount()];
        for (int i = 0; i < getColumnCount(); i++) {
            columnNames[i] = getColumnName(i);
        }
        return columnNames;
    }
}

