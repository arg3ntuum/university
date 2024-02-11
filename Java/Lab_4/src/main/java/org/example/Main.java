package org.example;

import java.util.Arrays;
import java.util.Random;

public class Main {
    public static void main(String[] args) {
        final int n = 10000;
        int[] arr1 = GenerateRandArr(n);
        int[] arr2 = GenerateRandArr(n);

        long time1 = System.currentTimeMillis();
        int[] result1 = MultDefault(arr1, arr2, 1);
        System.out.printf("Дефолт слип 1: %d ms\n", System.currentTimeMillis() - time1);

        long time2 = System.currentTimeMillis();
        int[] result2 = MultDefault(arr1, arr2, 0);
        System.out.printf("Дефолт слип 0: %d ms\n", System.currentTimeMillis() - time2);

        long time3 = System.currentTimeMillis();
        int[] result3 = MultParallel(arr1, arr2, 1);
        System.out.printf("Паралель слип 1: %d ms\n", System.currentTimeMillis() - time3);

        long time4 = System.currentTimeMillis();
        int[] result4 = MultParallel(arr1, arr2, 0);
        System.out.printf("Паралель слип 0: %d ms\n", System.currentTimeMillis() - time4);

        // Verify that all results are the same
        assert Arrays.equals(result1, result2);
        assert Arrays.equals(result1, result3);
        assert Arrays.equals(result1, result4);
    }

    private static int[] GenerateRandArr(int n) {
        int[] array = new int[n];
        Random rand = new Random();
        for (int i = 0; i < n; ++i) {
            array[i] = rand.nextInt(101);
        }
        return array;
    }

    private static int[] MultDefault(int[] arr1, int[] arr2, int sleep) {
        assert arr1.length == arr2.length;
        int n = arr1.length;
        int[] result = new int[n];
        for (int i = 0; i < n; ++i) {
            result[i] = arr1[i] * arr2[i];
            try {
                Thread.sleep(sleep);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }
        return result;
    }

    private static int[] MultParallel(int[] arr1, int[] arr2, int sleep) {
        assert arr1.length == arr2.length;
        int n = arr1.length;
        int[] result = new int[n];
        //устанавливает элементы массива с помощью лямбда-выражения
        Arrays.parallelSetAll(result, i ->
                {
                int value = arr1[i] * arr2[i];
                try { Thread.sleep(sleep);}
                catch (InterruptedException e) {throw new RuntimeException(e);}
                return value;
                }
        );
        return result;
    }
}