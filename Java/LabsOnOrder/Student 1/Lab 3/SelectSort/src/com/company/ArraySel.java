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
            int num1 = 0, num2 = 0;
            long number_in_masive, best_number = a[0];
            for (byte i = 0;i < num;i++)
            {
                number_in_masive = a[i];
                for (byte j = 0;j < num;j++){
                    if (number_in_masive == a[j])
                        num2++;
                    if (num2 > num1){
                        num1 = num2;
                        num2=0;
                        best_number = number_in_masive;
                    }
                }
                num2=0;
            }
            return best_number;
        }
}
