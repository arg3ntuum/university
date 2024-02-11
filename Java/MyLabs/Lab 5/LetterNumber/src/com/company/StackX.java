package com.company;


public class StackX {
    private int maxSize; // Розмір масиву
    private long[] stackArray;

    private int top; // Вершина стека

    public StackX(int s) { // Конструктор
        maxSize = s; // Визначення розміру стека
        stackArray = new long[maxSize]; // Створення масиву
        top = 0; // Поки немає жодного елемента
    }

    public void push(long j) {
        stackArray[++top] = j;
    }// Розміщення елемента на вершині стека
    public long pop() { // Витягування елемента з вершини стека
        return stackArray[top--];
    }
    public boolean isEmpty() { // True, якщо стек порожній
        return (top == -1);
    }

} // Кінець класу StackX
