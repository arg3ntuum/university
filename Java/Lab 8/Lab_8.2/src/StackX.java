class StackX {
    private char[] stackArray;
    private int top;
    private int maxSize;
    public StackX(int max) {
        maxSize = max;
        stackArray = new char[maxSize];
        top = -1;
    }
    public void push(char j) {
        stackArray[++top] = j;
    }
    public char pop() {
        return stackArray[top--];
    }
    public char peek() {
        return stackArray[top];
    }
    public boolean isEmpty() {
        return (top == -1);
    }
}

