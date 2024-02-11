class Person {
    private String lastName;
    private String firstName;
    private int age;
    public Person(String last, String first, int a) { // Конструктор
        lastName = last;
        firstName = first;
        age = a;
    }
    public void displayPerson() {
        System.out.print(" Last name: " + lastName);
        System.out.print(", First name: " + firstName);
        System.out.println(", Age: " + age);
    }
    public String getLast()
    {
        return lastName;
    }
}
class ArrayInOb {
    private Person[] a; // Посилання на масив a
    private int nElems; // Кількість елементів даних
    public ArrayInOb(int max){ // Конструктор
        a = new Person[max]; // Створення
        nElems = 0; // Поки що немає жодного елемента
    }
    public void insert(String last, String first, int age) {
        a[nElems] = new Person(last, first, age);
        nElems++; }
    public void display()
    {
        for (int j = 0; j < nElems; j++)
        {
            a[j].displayPerson();
        }
        System.out.println("");
    }
    public void insertionSort() {
        int in, out;
        for (out = 1; out < nElems; out++)
        {
            Person temp = a[out];
            in = out;
            while(in>0&&a[in-1].getLast().compareTo(temp.getLast())>0){
                a[in] = a[in - 1];
                --in;
            }
            a[in] = temp;
        }
    }}
class ObjectSortApp {
    public static void main(String[] args) {
        int maxSize = 100;
        ArrayInOb arr;
        arr = new ArrayInOb(maxSize);
        arr.insert("Evans", "Patty", 24);
        arr.insert("Smith", "Lorraine", 37);
        arr.insert("Yee", "Tom", 43);
        arr.insert("Adams", "Henry", 63);
        arr.insert("Hashimoto", "Sato", 21);
        arr.insert("Stimson", "Henry", 29);
        arr.insert("Velasquez", "Jose", 72);
        arr.insert("Lamarque", "Henry", 54);
        arr.insert("Vang", "Minh", 22);
        arr.insert("Creswell", "Lucinda", 18);
        System.out.println("Before sorting:");
        arr.display();
        arr.insertionSort();
        System.out.println("After sorting:");
        arr.display();
    }
}
