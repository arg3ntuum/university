public class SelectSortApp {
    public static void main(String[] args) {
        int maxSize = 100000; // Розмір
        ArraySel arr; // Посилання
        arr = new ArraySel(maxSize); // Створення
        for(int j=0; j<maxSize; j++){ // Заповнення масиву випадковими числами
            long n = (long)( java.lang.Math.random()*(maxSize-1) );
            arr.insert(n);
        }

        arr.display(); // Виведення елементів
        arr.antiSelectionSort();
        //arr.selectionSort();
        arr.display();
        arr.selectionSort();
        //arr.antiSelectionSort();
    }
}