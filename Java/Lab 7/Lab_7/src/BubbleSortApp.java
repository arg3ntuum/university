public class BubbleSortApp {
    public static void main(String[] args) {
        int maxSize = 100000; // Розмір
        ArrayBub arr; // Посилання на масив
        arr = new ArrayBub(maxSize); // Створення масиву
        for(int j=0; j<maxSize; j++){ // Заповнення масиву випадковими числами
            long n = (long)( java.lang.Math.random()*(maxSize-1) );
            arr.insert(n);
        }

        arr.antiBubbleSort(); // Пухирцеве сортування
        //arr.bubbleSort(); // Пухирцеве сортування
        arr.display();
        arr.bubbleSort(); // Пухирцеве сортування
        //arr.antiBubbleSort(); // Пухирцеве сортування
        arr.display();
    }
}
