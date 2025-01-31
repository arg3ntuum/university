package com.example.lab1;

import org.springframework.data.jpa.repository.JpaRepository;
import java.util.List;

public interface ImageRepository extends JpaRepository<Image, Long> {
    List<Image> findByGroupId(Long groupId);
}

