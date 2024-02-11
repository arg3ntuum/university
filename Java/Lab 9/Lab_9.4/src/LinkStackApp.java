
public class LinkStackApp {
    public static void main(String[] args) {
        LinkStack theStack = new  LinkStack(); // Створення стека
        theStack.push(20); // Вставка елементів
        theStack.push(40);
        theStack.displayStack(); // Виведення вмісту стека
        theStack.push(60); // Вставка елементів
        theStack.push(80);
        theStack.displayStack(); // Виведення вмісту стека
        theStack.pop(); // Вилучення елементів
        theStack.pop();
        theStack.displayStack(); // Виведення вмісту стека
    }}