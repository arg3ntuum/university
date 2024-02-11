class ArrayBub {
    private long[] a;
    private int nElems;
    public ArrayBub(int max) {
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
        System.out.println(" ");
    }
    public void bubbleSort() {
        int out, in;
        for (out = nElems - 1; out > 1; out--) // Зовнішній цикл (обратный
        {
            for (in = 0; in < out; in++) // Внутрішній цикл (прямий)
            {
                if (a[in] < a[in + 1]) // Порядок порушено?
                {
                    swap(in, in + 1);
                }
            }
        }
    }
    public void antiBubbleSort() {
        int out, in;
        for (out = nElems - 1; out > 1; out--) // Зовнішній цикл (обратный
        {
            for (in = 0; in < out; in++) // Внутрішній цикл (прямий)
            {
                if (a[in] > a[in + 1]) // Порядок порушено?
                {
                    swap(in, in + 1);
                }
            }
        }
    }
    public void swap(int one, int two) {
        long temp = a[one];
        a[one] = a[two];
        a[two] = temp;
    }
}

