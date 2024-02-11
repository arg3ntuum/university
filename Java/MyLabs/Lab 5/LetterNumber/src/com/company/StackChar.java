package com.company;

public class StackChar {
    private int maxSize; // Розмір масиву
    private char[] stackArrayChar;

    private int top; // Вершина стека

    public StackChar(int s) { // Конструктор
        maxSize = s; // Визначення розміру стека
        stackArrayChar = new char[maxSize]; // Створення масиву
        top = -1; // Поки немає жодного елемента
    }

    public void push(char j) {
        stackArrayChar[++top] = j;
    }// Розміщення елемента на вершині стека
    public char pop() { // Витягування елемента з вершини стека
        return stackArrayChar[top--];
    }
    public boolean isEmpty() { // True, якщо стек порожній
        return (top == -1);
    }
    public boolean isFull() { // True, якщо стек повний
        return (top == maxSize - 1);
    }

}
