public class StackWithDequeApp {
    public static void main(String[] args) {
        StackWithDeque theStack = new StackWithDeque(5);

        theStack.insertRight(10);
        theStack.insertRight(20);
        theStack.insertRight(30);

        theStack.displayDeque(); // Вивести вміст стека

        System.out.println("Removed from right: " + theStack.removeRight());
        System.out.println("Removed from left: " + theStack.removeLeft());

        theStack.insertRight(40);
        theStack.insertRight(50);

        theStack.displayDeque(); // Вивести вміст стека
        while (!theStack.isEmpty()) {
            System.out.println("Removed from right: " + theStack.removeRight());
        }

        theStack.displayDeque(); // Вивести вміст стека
    }
}