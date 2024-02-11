public class Main {
    public static void main(String[] args) {
        StackX theStack = new StackX(1000);
        theStack.push(20);
        theStack.push(40);
        theStack.push(60);
        theStack.push(80);

        while (!theStack.isEmply()) {
            long value = theStack.pop();
            System.out.println(value);
        }
    }
}
