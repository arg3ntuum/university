import java.security.PublicKey;

public class Calculation {
    private float memory;
    private float data; // ɨɛɪɨɛɥɸɜɚɧɿ ɞɚɧɿ
    private char operation; // ɨɛɪɚɧɚ ɨɩɟɪɚɰɿɹ
    private String history;
    public Calculation(){ // ɤɨɧɫɬɪɭɤɬɨɪ
        memory = 0;
        data = 0;
        operation = ' '; }
    private void setData(float data){ // ɭɫɬɚɧɨɜɤɚ ɡɧɚɱɟɧɧɹ data
        this.data = data; }
    public void add(float a){ // ɨɩɟɪɚɰɿɹ ɞɨɞɚɜɚɧɧɹ
        operation = '+';
        setData(a); }
    public void mult(float a){ // ɨɩɟɪɚɰɿɹ ɞɨɞɚɜɚɧɧɹ
        operation = '*';
        setData(a); }
    public void min(float a){ // ɨɩɟɪɚɰɿɹ ɞɨɞɚɜɚɧɧɹ
        operation = '-';
        setData(a); }
    public void div(float a){ // ɨɩɟɪɚɰɿɹ ɞɨɞɚɜɚɧɧɹ
        operation = '/';
        setData(a); }
    public void exp(float a){ // ɨɩɟɪɚɰɿɹ ɞɨɞɚɜɚɧɧɹ
        operation = '^';
        setData(a); }
    public void mr(){
        setData(memory);
    }
    public void ms(){
        memory = data;
    }
    public void mc(){
        memory = 0;
    }
    public void mp(){
        memory += data;
    }
    public void mm(){
        memory -= data;
    }
// ...
    private void setHistory(float a, float b){
        history = "\n" + a + " " + operation + " " + b + " = " + getResult(b);
    }
    public String getHistory() {
        return history;
    }

public float getData(){ // ɨɬɪɢɦɚɬɢ ɡɧɚɱɟɧɧɹ data
    return data; }
    public float clear(){ // ɨɱɢɳɟɧɧɹ ɩɨɥɿɜ
        setData(0);
        operation = ' ';
        return data; }
    public float equal(float b){ // ɨɬɪɢɦɚɬɢ ɪɟɡɭɥьɬɚɬ
        setHistory(getData(), b);
        switch(operation){ // ɜɢɡɧɚɱɟɧɧɹ ɨɛɪɚɧɨʀ ɨɩɟɪɚɰɿʀ
            case '+': {
                setData(getData() + b);
                operation = ' ';
                break; }
            case '*': {
                setData(getData() * b);
                operation = ' ';
                break; }
            case '-': {
                setData(getData() - b);
                operation = ' ';
                break; }
            case '/': {
                setData(getData() / b);
                operation = ' ';
                break; }
            case '^': {
                setData((float) Math.pow(getData(), b));
                operation = ' ';
                break; }
// ...
        }

        return getData();}
    public float getResult(float b){ // ɨɬɪɢɦɚɬɢ ɪɟɡɭɥьɬɚɬ
        switch(operation) {
            case '+': {
                return (getData() + b);
            }
            case '*': {
                return (getData() * b);
            }
            case '-': {
                return (getData() - b);
            }
            case '/': {
                return (getData() / b);
            }
            case '^': {
                return ((float) Math.pow(getData(), b));
            }
        }
            return 0;
    }
}
