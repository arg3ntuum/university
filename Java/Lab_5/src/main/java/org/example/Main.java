package org.example;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;
import java.time.LocalTime;

public class Main {
    private volatile int counter = 0;

    public static void main(String[] args) {
        Main program = new Main();
        program.start();
    }

    private void start() {
        Thread thread1 = new Thread(new MyRunnable("Thread 1", 250));
        Thread thread2 = new Thread(new MyRunnable("Thread 2", 500));
        Thread thread3 = new Thread(new MyRunnable("Thread 3", 1000));

        thread1.start();
        thread2.start();
        thread3.start();

        while (counter < 240) {
            try {
                Thread.sleep(1000);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }

        thread1.interrupt();
        thread2.interrupt();
        thread3.interrupt();
    }

    private synchronized void writeToFile(String threadName, int value) {
        try (BufferedWriter writer = new BufferedWriter(new FileWriter("log.txt", true))) {
            writer.write(String.format("%s %s %d\n", threadName, LocalTime.now(), value));
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private class MyRunnable implements Runnable {
        private final String threadName;
        private final int sleepTime;

        public MyRunnable(String threadName, int sleepTime) {
            this.threadName = threadName;
            this.sleepTime = sleepTime;
        }

        @Override
        public void run() {
            while (!Thread.currentThread().isInterrupted()) {
                writeToFile(threadName, counter++);
                try {
                    Thread.sleep(sleepTime);
                } catch (InterruptedException e) {
                    Thread.currentThread().interrupt();
                }
            }
        }
    }
}