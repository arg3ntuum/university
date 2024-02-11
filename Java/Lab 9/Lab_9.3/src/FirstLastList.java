public class FirstLastList {
    private Link first;
    private Link last;
    public void LinkList() {
        first = null;
        last = null;
    }
    public Link find(int key) {
        Link current = first;
        while (current.iData != key) {
            if (current.next == null) {
                return null;
            } else {
                current = current.next;
            }
        }
        return current;
    }
    public boolean isEmpty() {
        return (first == null);
    }
    public void insertFirst(int id, double dd) {
        Link newLink = new Link(id, dd);
        if (isEmpty()) {
            last = newLink;
        }
        newLink.next = first;
        first = newLink;
    }
    public void insertLast(int id, double dd) {
        Link newLink = new Link(id, dd);
        if (isEmpty()) {
            last = newLink;
        } else {
            last.next = newLink;
            last = newLink;
        }
    }
    public long deleteFirst() {
        long temp = first.iData;
        if (first.next == null) {
            last = null;
        }
        first = first.next;
        return temp;
    }
    public void displayList() {
        System.out.print("List (first --> last): ");
        Link current = first;
        while (current != null) {
            current.displayLink();
            current = current.next;
        }
    }
}