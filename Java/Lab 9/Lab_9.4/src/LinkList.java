public class LinkList {
    private Link first;
    public LinkList() // Конструктор
    {
        first = null;
    }
    public boolean isEmpty() // true, якщо список порожній
    {
        return (first == null);
    }
    public void insertFirst(long dd) // Вставка елемента на початоксписку
    { // Створення нового елемента
        Link newLink = new Link(dd);
        newLink.next = first; // newLink --> старе значення first
        first = newLink; // first --> newLink
    }
    public long deleteFirst() // Видалення першого елемента
    { // (передбачається, що список не порожній)
        Link temp = first; // Збереження посилання
        first = first.next; // Вилучення: first-->посилання на другий элемент

        return temp.dData; // Метод повертає дані
    }
    public void displayList() {
        Link current = first; // Від початку списку
        while (current != null) // Переміщення остаточно списку
        {
            current.displayLink(); // Виведення даних
            current = current.next; // Перехід до наступного елементу
        }
        System.out.println("");
    }
}