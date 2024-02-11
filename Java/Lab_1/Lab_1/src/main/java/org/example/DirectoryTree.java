package org.example;
import java.io.File;

public class DirectoryTree {

    public static void main(String[] args) {
        File currentDir = new File(".");
        displayDirectoryContents(currentDir, 0);
    }

    public static void displayDirectoryContents(File dir, int depth) {
        String prefix = getPrefix(depth);
        System.out.println(prefix + dir.getName());

        if (dir.isDirectory()) {
            File[] files = dir.listFiles();
            if (files != null) {
                for (File file : files) {
                    displayDirectoryContents(file, depth + 1);
                }
            }
        }
    }

    public static String getPrefix(int depth) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < depth; i++) {
            sb.append("\t");
        }
        return sb.toString();
    }
}