package com.company;

public class StackX {
    private int maxSize; // Розмір масиву
    private long[] stackArray;
    private int top; // Вершина стека

    public StackX() { // Конструктор
        maxSize = 30; // Визначення розміру стека
        stackArray = new long[maxSize]; // Створення масиву
        top = -1; // Поки немає жодного елемента
    }
    /*
    public static void main(String[] args) {

       Cat[] cats = new Cat[3];
       cats[0] = new Cat("Томас");
       cats[1] = new Cat("Бегемот");
       cats[2] = new Cat("Филипп Маркович");
   }
   */
    public void push(long j) { // Розміщення елемента на вершині стека
        stackArray[++top] = j;
    }
    public long pop() { // Витягування елемента з вершини стека
        return stackArray[top--];
    }
    public long peek() { // Читання елемента з вершини стека
        return stackArray[top];
    }
    public boolean isEmpty() { // True, якщо стек порожній
        return (top == -1);
    }
    public boolean isFull() { // True, якщо стек повний
        return (top == maxSize - 1);
    }

} // Кінець класу StackX
