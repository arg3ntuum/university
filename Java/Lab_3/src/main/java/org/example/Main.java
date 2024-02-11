package org.example;
import java.util.Scanner;
import java.util.concurrent.CompletableFuture;
import java.util.logging.Level;
import java.util.logging.Logger;
public class Main {
//https://levelup.gitconnected.com/completablefuture-a-new-era-of-asynchronous-programming-86c2fe23e246
    private static final Logger LOGGER = Logger.getLogger(Main.class.getName());
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Введіть n: ");
        int n = scanner.nextInt();

        CompletableFuture<Integer> future = CompletableFuture.supplyAsync(() -> fibonacci(n));
        LOGGER.log(Level.INFO, "Обчислювальний потік запущено.");
        //System.out.println("Обчислювальний потік запущено.");



        future.thenAccept(result -> {
            LOGGER.log(Level.INFO, "Отримане значення: {0}", result);
            //System.out.println("Отримане значення: " + result);
        });
        for(int i = 0; i < 10; i++)
            System.out.println("Обчислення...");
        // Очікуємо завершення асинхронного обчислювання
        future.join();
        LOGGER.log(Level.INFO,"Асинхронний потік завершено.");
        //System.out.println("Асинхронний потік завершено.");
    }
    private static int fibonacci(int n) {
        System.out.println("fibonacci");
        if (n <= 1) {
            return n;
        } else {
            return fibonacci(n-1) + fibonacci(n-2);
        }
    }
}
