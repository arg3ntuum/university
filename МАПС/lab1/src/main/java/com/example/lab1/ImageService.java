package com.example.lab1;

import org.springframework.stereotype.Service;
import org.springframework.web.multipart.MultipartFile;

import javax.imageio.ImageIO;
import java.awt.*;
import java.awt.image.BufferedImage;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.Stream;

@Service
public class ImageService {

    private final ImageRepository imageRepository;

    public ImageService(ImageRepository imageRepository) {
        this.imageRepository = imageRepository;
    }

    public List<Image> saveImageGroup(MultipartFile file) throws IOException {
        Long groupId = System.currentTimeMillis(); // Унікальний ідентифікатор групи
        return Stream.of(128, 256, 512)
                .map(size -> saveImage(file, size, size, groupId))
                .collect(Collectors.toList());
    }

    public List<Image> getImagesByGroupId(Long groupId) {
        return imageRepository.findByGroupId(groupId);
    }

    public List<Long> getAllGroups() {
        return imageRepository.findAll().stream()
                .map(Image::getGroupId)
                .distinct()
                .collect(Collectors.toList());
    }

    public Image getImageById(Long id) {
        return imageRepository.findById(id).orElse(null);
    }

    private Image saveImage(MultipartFile file, int width, int height, Long groupId) {
        try {
            BufferedImage originalImage = ImageIO.read(file.getInputStream());
            BufferedImage resizedImage = resizeImage(originalImage, width, height);

            ByteArrayOutputStream baos = new ByteArrayOutputStream();
            ImageIO.write(resizedImage, "jpg", baos);

            Image image = new Image();
            image.setFileName(file.getOriginalFilename());
            image.setImageData(baos.toByteArray());
            image.setWidth(width);
            image.setHeight(height);
            image.setGroupId(groupId);

            return imageRepository.save(image);
        } catch (IOException e) {
            throw new RuntimeException("Failed to save image", e);
        }
    }

    private BufferedImage resizeImage(BufferedImage originalImage, int width, int height) {
        BufferedImage resizedImage = new BufferedImage(width, height, BufferedImage.TYPE_INT_RGB);
        Graphics2D g = resizedImage.createGraphics();
        g.drawImage(originalImage, 0, 0, width, height, null);
        g.dispose();
        return resizedImage;
    }
}


