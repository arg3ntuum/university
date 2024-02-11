package com.company;
import java.util.*;
import java.io.*;

public class StackX {
    private int maxSize; // Розмір масиву
    private long[] stackArray;
    private int top; // Вершина стека

    public StackX(int s) { // Конструктор
        maxSize = s; // Визначення розміру стека
        stackArray = new long[maxSize]; // Створення масиву
        top = -1; // Поки немає жодного елемента
    }

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
