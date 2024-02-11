public class Conversion {
    public static double convert(String inputType, String outputType, double value) {
        switch (inputType) {
            case "mg":
                return convertFromMilligrams(value, outputType);
            case "g":
                return convertFromGrams(value, outputType);
            case "kg":
                return convertFromKilograms(value, outputType);
            case "t":
                return convertFromTonnes(value, outputType);
            case "c":
                return convertFromCentners(value, outputType);
            default:
                throw new IllegalArgumentException("Неподдерживаемый тип входных данных");
        }
    }

    private static double convertFromMilligrams(double value, String outputType) {
        switch (outputType) {
            case "mg":
                return value;
            case "g":
                return value / 1000;
            case "kg":
                return value / 1_000_000;
            case "t":
                return value / 1_000_000_000;
            case "c":
                return value / 10_000_000;
            default:
                throw new IllegalArgumentException("Неподдерживаемый тип выходных данных");
        }
    }

    private static double convertFromGrams(double value, String outputType) {
        switch (outputType) {
            case "mg":
                return value * 1000;
            case "g":
                return value;
            case "kg":
                return value / 1000;
            case "t":
                return value / 1_000_000;
            case "c":
                return value / 10_000;
            default:
                throw new IllegalArgumentException("Неподдерживаемый тип выходных данных");
        }
    }

    private static double convertFromKilograms(double value, String outputType) {
        switch (outputType) {
            case "mg":
                return value * 1_000_000;
            case "g":
                return value * 1000;
            case "kg":
                return value;
            case "t":
                return value / 1000;
            case "c":
                return value / 10;
            default:
                throw new IllegalArgumentException("Неподдерживаемый тип выходных данных");
        }
    }

    private static double convertFromTonnes(double value, String outputType) {
        switch (outputType) {
            case "mg":
                return value * 1_000_000_000;
            case "g":
                return value * 1_000_000;
            case "kg":
                return value * 1_000;
            case "t":
                return value;
            case "c":
                return value * 10;
            default:
                throw new IllegalArgumentException("Неподдерживаемый тип выходных данных");
        }
    }

    private static double convertFromCentners(double value, String outputType) {
        switch (outputType) {
            case "mg":
                return value * 10_000_000;
            case "g":
                return value * 10_000;
            case "kg":
                return value * 100;
            case "t":
                return value / 10;
            case "c":
                return value;
            default:
                throw new IllegalArgumentException("Неподдерживаемый тип выходных данных");
        }
    }
}
