public class InsertSortApp {
    public static void main(String[] args) {
        int maxSize = 100000; // Розмір
        ArrayIns arr; // Посилання
        arr = new ArrayIns(maxSize); // Створення масиву
        for(int j=0; j<maxSize; j++){ // Заповнення масиву випадковими числами
            long n = (long)( java.lang.Math.random()*(maxSize-1) );
            arr.insert(n);
        }
        arr.display();
        //arr.insertionSort();
        arr.antiInsertionSort();
        arr.display();
        //arr.antiInsertionSort();
        arr.insertionSort();
    }
}