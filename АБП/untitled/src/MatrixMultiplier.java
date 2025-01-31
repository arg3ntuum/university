import java.util.Random;
import java.util.concurrent.*;
import java.util.concurrent.atomic.AtomicInteger;

// до 50 ел

public class MatrixMultiplier {
    private final int[][] matrixA;
    private final int[][] matrixB;
    private final int[][] resultMatrix;
    private final int rowsA, colsA, rowsB, colsB;

    public MatrixMultiplier(int[][] matrixA, int[][] matrixB) {
        this.matrixA = matrixA;
        this.matrixB = matrixB;
        this.rowsA = matrixA.length;
        this.colsA = matrixA[0].length;
        this.rowsB = matrixB.length;
        this.colsB = matrixB[0].length;

        if (colsA != rowsB) {
            throw new IllegalArgumentException("Matrix dimensions do not match for multiplication");
        }

        this.resultMatrix = new int[rowsA][colsB];
    }

    public void multiplyUsingThreadPool(int threadPoolSize) {
        ExecutorService executor = Executors.newFixedThreadPool(threadPoolSize);
        performMultiplication(executor);
    }

    public void multiplyUsingVirtualThreads() {
        ExecutorService executor = Executors.newVirtualThreadPerTaskExecutor();
        performMultiplication(executor);
    }

    private void performMultiplication(ExecutorService executor) {
        AtomicInteger currentIndex = new AtomicInteger(0);
        int totalElements = rowsA * colsB;

        CountDownLatch latch = new CountDownLatch(totalElements);

        for (int i = 0; i < totalElements; i++) {
            executor.submit(() -> {
                int index = currentIndex.getAndIncrement();
                if (index >= totalElements) {
                    return;
                }

                int row = index / colsB;
                int col = index % colsB;

                resultMatrix[row][col] = calculateElement(row, col);
                latch.countDown();
            });
        }

        try {
            latch.await();
        } catch (InterruptedException e) {
            Thread.currentThread().interrupt();
            System.err.println("Execution interrupted: " + e.getMessage());
        } finally {
            executor.shutdown();
        }
    }

    private int calculateElement(int row, int col) {
        int sum = 0;
        for (int i = 0; i < colsA; i++) {
            sum += matrixA[row][i] * matrixB[i][col];
        }
        return sum;
    }

    public void printResult() {
        for (int[] row : resultMatrix) {
            for (int value : row) {
                System.out.printf("%4d", value);
            }
            System.out.println();
        }
    }

    public static int[][] generateMatrix(int rows, int cols, int bound) {
        Random random = new Random();
        int[][] matrix = new int[rows][cols];

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                matrix[i][j] = random.nextInt(bound);
            }
        }

        return matrix;
    }

    public static void printMatrix(int[][] matrix) {
        for (int[] row : matrix) {
            for (int value : row) {
                System.out.printf("%4d", value);
            }
            System.out.println();
        }
    }

    public static void main(String[] args) {
        int size = 200;
        int[][] matrixA = generateMatrix(size, size, 10);
        int[][] matrixB = generateMatrix(size, size, 10);

        System.out.println("MatrixA:");
        //printMatrix(matrixA);
        System.out.println();

        System.out.println("MatrixB:");
        //printMatrix(matrixB);
        System.out.println();

        MatrixMultiplier multiplier = new MatrixMultiplier(matrixA, matrixB);

        // Test with ThreadPool
        long startTime = System.nanoTime();
        multiplier.multiplyUsingThreadPool(4);
        long endTime = System.nanoTime();
        System.out.println("Result using ThreadPool:");
        //multiplier.printResult();
        System.out.println("Execution Time (ThreadPool): " + (endTime - startTime) / 1_000_000 + " ms");

        // Test with Virtual Threads
        startTime = System.nanoTime();
        multiplier.multiplyUsingVirtualThreads();
        endTime = System.nanoTime();
        System.out.println("Result using Virtual Threads:");
        //multiplier.printResult();
        System.out.println("Execution Time (Virtual Threads): " + (endTime - startTime) / 1_000_000 + " ms");
    }
}
