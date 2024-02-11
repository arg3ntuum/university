class Deque {
    private int maxSize;
    private long[] dequeArray;
    private int left;
    private int right;
    private int nItems;

    public Deque(int s) {
        maxSize = s;
        dequeArray = new long[maxSize];
        left = 0;
        right = -1;
        nItems = 0;
    }

    public void displayDeque() {
        if (isEmpty()) {
            System.out.println("Deque is empty");
            return;
        }
        int current = left;
        int count = 0;
        while (count < nItems) {
            System.out.print(dequeArray[current] + " ");
            current = (current + 1) % maxSize;
            count++;
        }
        System.out.println();
    }

    public void insertLeft(long j) {
        if (left == 0)
            left = maxSize;
        dequeArray[--left] = j;
        nItems++;
    }

    public void insertRight(long j) {
        if (right == maxSize - 1)
            right = -1;
        dequeArray[++right] = j;
        nItems++;
    }

    public long removeLeft() {
        long temp = dequeArray[left++];
        if (left == maxSize)
            left = 0;
        nItems--;
        return temp;
    }

    public long removeRight() {
        long temp = dequeArray[right--];
        if (right == -1)
            right = maxSize - 1;
        nItems--;
        return temp;
    }

    public boolean isEmpty() {
        return (nItems == 0);
    }

    public boolean isFull() {
        return (nItems == maxSize);
    }
}

