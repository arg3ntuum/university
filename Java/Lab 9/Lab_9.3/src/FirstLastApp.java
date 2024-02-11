
public class FirstLastApp {
    public static void main(String args[]) {
        FirstLastList theList = new FirstLastList();
        theList.insertFirst(22, 2.99);
        theList.insertFirst(44, 4.99);
        theList.insertFirst(66, 8.99);
        theList.insertLast(23, 32.99);
        theList.insertLast(33, 52.99);
        theList.insertLast(55, 22.99);
        theList.insertLast(123, 11.99);
        theList.displayList();

    }
}