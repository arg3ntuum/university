public class LinkQueue {
    private LinkList theList;
    public LinkQueue()
    {
        theList = new LinkList();
    }
    public boolean isEmpty()
    {
        return theList.isEmpty();
    }
    public void insert(long j)
    {
        theList.insertLast(j);
    }
    public long remove()
    {
        return theList.deleteFirst();
    }
    public void displayQueue() {
        System.out.print("Queue (front-->rear): ");
        theList.displayList();
    }
}