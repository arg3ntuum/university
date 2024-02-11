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
        public long moda(int kolvo){
            int kolvo1 = 0, kolvo2 = 0;
            long chislo, best_chislo = a[0];
            for (byte i = 0;i < kolvo;i++)
            {
                chislo = a[i];
                for (byte j = 0;j < kolvo;j++){

                    if (chislo == a[j])
                        kolvo2++;
                    if (kolvo2 > kolvo1){
                        kolvo1 = kolvo2;
                        kolvo2=0;
                        best_chislo = chislo;
                    }
                }
                kolvo2=0;
            }
            return best_chislo;
        }
}
