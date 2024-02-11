public class DequeApp {
    public static void main(String[] args) {
        Deque theDeque = new Deque(5);

        theDeque.insertLeft(10);
        theDeque.insertRight(20);
        theDeque.insertLeft(30);
        theDeque.insertRight(40);

        theDeque.displayDeque();

        System.out.println("Removed from left: " + theDeque.removeLeft());
        System.out.println("Removed from right: " + theDeque.removeRight());

        theDeque.insertLeft(50);
        theDeque.insertRight(60);

        theDeque.displayDeque();

        while (!theDeque.isEmpty()) {
            System.out.println("Removed from left: " + theDeque.removeLeft());
        }

        theDeque.displayDeque();
    }
}


