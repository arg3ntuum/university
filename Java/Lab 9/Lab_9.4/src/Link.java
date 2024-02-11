public class Link {
    public long dData; // Дані
    public Link next; // Наступний елемент у списку
    public Link(long dd) // Конструктор
    {
        dData = dd;
    }
    public void displayLink() {
        System.out.print(dData + " ");
    }
}