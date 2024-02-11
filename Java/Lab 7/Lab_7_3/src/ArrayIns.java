class ArrayIns {
    private long[] a;
    private int nElems;

    public ArrayIns(int max) {
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
        System.out.println("");
    }

    public void insertionSort() {
        int in, out;
        for (out = 1; out < nElems; out++) { // розділовий маркер
            long temp = a[out]; // Копіювати позначений елемент
            in = out; // почати переміщення з out
            while (in > 0 && a[in - 1] >= temp) { // Поки що не знайдено
                a[in] = a[in - 1]; // зрушити елемент праворуч
                --in; // перейти на одну позицію вліво
            }
            a[in] = temp; // вставити позначений елемент
        }

    }
    public void antiInsertionSort() {
        int in, out;
        for (out = 1; out < nElems; out++) { // Розділовий маркер
            long temp = a[out]; // Копіювати позначений елемент
            in = out; // Почати переміщення з out
            while (in > 0 && a[in - 1] <= temp) { // Змінено умову порівняння
                a[in] = a[in - 1]; // Зрушити елемент праворуч
                --in; // Перейти на одну позицію вліво
            }
            a[in] = temp; // Вставити позначений елемент
        }
    }
}
