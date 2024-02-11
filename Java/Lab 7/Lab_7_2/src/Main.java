class ArraySel {
    private long[] a;
    private int nElems;
    public ArraySel(int max) {
        a = new long[max];
        nElems = 0;
    }
    public void insert(long value) {
        a[nElems] = value;
        nElems++;
    }
    public void display() {
        for (int j = 0; j < nElems; j++) {
            System.out.print(a[j] + " ");
        }
    }
    public void selectionSort() {
        int out, in, min;
        for (out = 0; out < nElems - 1; out++) // Зовнішній цикл
        {
            min = out; // Мінімум
            for (in = out + 1; in < nElems; in++) // Внутрішній цикл
            {
                if (a[in] < a[min]) // Якщо значення min більше,
                {
                    min = in; // отже, знайдено новий мінімум
                }
            }
            swap(out, min); // Поміняти їх місцями
        }
    }

    public void antiSelectionSort() {
        int out, in, min;
        for (out = 0; out < nElems - 1; out++) // Зовнішній цикл
        {
            min = out; // Мінімум
            for (in = out + 1; in < nElems; in++) // Внутрішній цикл
            {
                if (a[in] > a[min]) // Якщо значення min більше,
                {
                    min = in; // отже, знайдено новий мінімум
                }
            }
            swap(out, min); // Поміняти їх місцями
        }
    }

            public void swap(int one, int two) {
        long temp = a[one];
        a[one] = a[two];
        a[two] = temp;
    }
}

