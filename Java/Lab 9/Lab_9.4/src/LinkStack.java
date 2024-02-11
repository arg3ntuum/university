public class LinkStack {
    private LinkList theList;
    public LinkStack() // Конструктор
    {
        theList = new LinkList();
    }
    public void push(long j) // Розміщення елемента на вершині стека
    {
        theList.insertFirst(j);
    }
    public long pop() // Вилучення елемента з вершини стека
    {
        return theList.deleteFirst();
    }
    public boolean isEmpty() // true, якщо стек порожній
    {
        return (theList.isEmpty());
    }
    public void displayStack() {
        System.out.print("Stack (top->bottom): ");
        theList.displayList();
    }
}