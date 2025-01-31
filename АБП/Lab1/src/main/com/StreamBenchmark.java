package main.com;

import org.openjdk.jmh.annotations.*;
import java.util.List;
import java.util.Random;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

@State(Scope.Benchmark)
public class StreamBenchmark {

    private static final int SIZE = 10_000_000;
    private List<Integer> numbers;

    @Setup
    public void setup() {
        Random random = new Random();
        numbers = IntStream.range(0, SIZE)
                .map(i -> random.nextInt(100) + 1)
                .boxed()
                .collect(Collectors.toList());
    }

    // 1. Сума елементів у колекції
    @Benchmark
    public int sumSequential() {
        return numbers.stream().mapToInt(Integer::intValue).sum();
    }

    @Benchmark
    public int sumParallel() {
        return numbers.parallelStream().mapToInt(Integer::intValue).sum();
    }

    // 2. Середнє значення елементів колекції
    @Benchmark
    public double averageSequential() {
        return numbers.stream().mapToInt(Integer::intValue).average().orElse(0.0);
    }

    @Benchmark
    public double averageParallel() {
        return numbers.parallelStream().mapToInt(Integer::intValue).average().orElse(0.0);
    }

    // 3. Стандартне відхилення
    @Benchmark
    public double standardDeviationSequential() {
        double avg = averageSequential();
        return Math.sqrt(numbers.stream()
                .mapToDouble(i -> Math.pow(i - avg, 2))
                .average()
                .orElse(0.0));
    }

    @Benchmark
    public double standardDeviationParallel() {
        double avg = averageParallel();
        return Math.sqrt(numbers.parallelStream()
                .mapToDouble(i -> Math.pow(i - avg, 2))
                .average()
                .orElse(0.0));
    }

    // 4. Множення кожного елемента на 2
    @Benchmark
    public List<Integer> multiplySequential() {
        return numbers.stream()
                .map(i -> i * 2)
                .collect(Collectors.toList());
    }

    @Benchmark
    public List<Integer> multiplyParallel() {
        return numbers.parallelStream()
                .map(i -> i * 2)
                .collect(Collectors.toList());
    }

    // 5. Фільтрація: залишити парні значення, які діляться на 3
    @Benchmark
    public List<Integer> filterSequential() {
        return numbers.stream()
                .filter(i -> i % 2 == 0 && i % 3 == 0)
                .collect(Collectors.toList());
    }

    @Benchmark
    public List<Integer> filterParallel() {
        return numbers.parallelStream()
                .filter(i -> i % 2 == 0 && i % 3 == 0)
                .collect(Collectors.toList());
    }
}
