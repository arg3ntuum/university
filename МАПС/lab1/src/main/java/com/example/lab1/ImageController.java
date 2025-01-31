package com.example.lab1;

import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.multipart.MultipartFile;

import java.io.IOException;

@Controller
public class ImageController {

    private final ImageService imageService;

    public ImageController(ImageService imageService) {
        this.imageService = imageService;
    }

    @GetMapping("/")
    public String index(Model model) {
        model.addAttribute("groups", imageService.getAllGroups());
        return "index";
    }

    @PostMapping("/upload")
    public String uploadImage(@RequestParam("image") MultipartFile file) throws IOException {
        imageService.saveImageGroup(file);
        return "redirect:/";
    }

    @GetMapping("/group/{groupId}")
    public String getGroup(@PathVariable Long groupId, Model model) {
        model.addAttribute("images", imageService.getImagesByGroupId(groupId));
        model.addAttribute("groupId", groupId); // Передаємо groupId для заголовку
        return "group";
    }

    @GetMapping("/image/{id}")
    public ResponseEntity<byte[]> getImage(@PathVariable Long id) {
        Image image = imageService.getImageById(id);

        if (image != null) {
            HttpHeaders headers = new HttpHeaders();
            headers.setContentType(MediaType.IMAGE_JPEG);
            return new ResponseEntity<>(image.getImageData(), headers, HttpStatus.OK);
        }

        return new ResponseEntity<>(HttpStatus.NOT_FOUND);
    }
}

