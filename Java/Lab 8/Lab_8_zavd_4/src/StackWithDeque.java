class StackWithDeque {
    private Deque deque;

    public StackWithDeque(int maxSize) {
        deque = new Deque(maxSize);
    }

    public void insertLeft(long j) {
        deque.insertLeft(j);
    }

    public void insertRight(long j) {
        deque.insertRight(j);
    }

    public long removeLeft() {
        return deque.removeLeft();
    }

    public long removeRight() {
        return deque.removeRight();
    }

    public boolean isEmpty() {
        return deque.isEmpty();
    }

    public boolean isFull() {
        return deque.isFull();
    }

    public void displayDeque() {
        deque.displayDeque();
    }
}
