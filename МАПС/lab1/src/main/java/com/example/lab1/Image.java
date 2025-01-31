package com.example.lab1;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

@Entity
@Getter
@Setter
public class Image {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @Column(nullable = false)
    private String fileName;

    @Lob
    private byte[] imageData;

    private int width;
    private int height;

    @Column(nullable = false)
    private Long groupId; // Група зображень (для 128, 256, 512 px)
}


