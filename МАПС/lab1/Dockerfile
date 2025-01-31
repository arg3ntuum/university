FROM openjdk:23-jdk-slim
VOLUME /tmp
RUN apt-get update && apt-get install -y curl && \
    curl -sSLo /wait-for-it.sh https://raw.githubusercontent.com/vishnubob/wait-for-it/master/wait-for-it.sh && \
    chmod +x /wait-for-it.sh
COPY build/libs/lab1-0.0.1-SNAPSHOT.jar app.jar
ENTRYPOINT ["java", "-jar", "/app.jar"]