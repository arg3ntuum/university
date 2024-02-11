package com.company;

public class ArraySel {
        private long[] a; // Посилання на масив a
        private int nElems; // Кількість елементів даних

        public ArraySel(int max) { // Конструктор
            a = new long[max]; // Створення масиву
            nElems = 0; // Поки немає жодного елемента
        }
        public void insert(long value) { // Вставка елемента в масив
            a[nElems] = value; // Власне вставка
            nElems++; // Збільшення розміру
        }
        public void display() { // Вивід вмісту масиву
            for(int j = 0; j<nElems; j++) // Для кожного елемента
                System.out.print(a[j] + " "); // Вивід
            System.out.println("");
        }
        public void selectSort() {
        int out, in, min;
        for(out = 0; out < nElems - 1; out++) { // Зовнішній цикл
            min = out; // Мінімум
            for(in = out + 1; in < nElems; in++) // Внутрішній цикл
                if(a[in] < a[min]) // Якщо значення min більше,
                    min = in; // Значить знайдений новий мінімум
            swap(out, min); // Поміняти їх місцями
        }
        }
        private void swap(int one, int two) {
        long temp = a[one];
        a[one] = a[two];
        a[two] = temp;
        }
        public long moda(int num){
            int number_1 = 0, number_2 = 0;
            long massive_num, best_number = a[0];
            for (byte i = 0;i < num;i++)
            {
                massive_num = a[i];
                for (byte j = 0;j < num;j++){
                    if (massive_num == a[j])
                        number_2++;
                    if (number_2 > number_1){
                        number_1 = number_2;
                        number_2=0;
                        best_number = massive_num;
                    }
                }
                number_2=0;
            }
            return best_number;
        }
}
