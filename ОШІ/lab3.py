import numpy as np
import matplotlib.pyplot as plt
import pandas as pd

from keras.layers import Input, Dense
from keras import Model
from keras.losses import sparse_categorical_crossentropy
from keras.metrics import sparse_categorical_accuracy
from keras.optimizers import Adam


# Клас для завантаження та підготовки даних
class DataLoader:
    def __init__(self, train_path, test_path):
        self.train_path = train_path
        self.test_path = test_path
        self.X_train = None
        self.Y_train = None
        self.X_test = None
        self.Y_test = None

    def load_data(self):
        # Завантаження тренувальних даних
        train = pd.read_csv(self.train_path).values
        self.Y_train = train[:, 0]  # мітки класів
        self.X_train = train[:, 1:]  # піксельні значення зображень

        # Завантаження тестових даних
        test = pd.read_csv(self.test_path).values
        self.Y_test = test[:, 0]  # мітки класів
        self.X_test = test[:, 1:]  # піксельні значення зображень

        # Нормалізація даних до діапазону [0, 1]
        self.X_train, self.X_test = self.X_train / 10.0, self.X_test / 10.0

        # Перетворення даних у форму (n_samples, 784) для використання в мережі
        self.X_train = self.X_train.reshape(-1, 784)
        self.X_test = self.X_test.reshape(-1, 784)

    def get_data(self):
        return self.X_train, self.Y_train, self.X_test, self.Y_test


# Клас для створення та тренування моделі
class DigitClassifier:
    def __init__(self, input_shape, learning_rate=0.001):
        self.input_shape = input_shape
        self.learning_rate = learning_rate
        self.model = self._build_model()

    def _build_model(self):
        # Створення архітектури моделі
        x = Input(shape=(self.input_shape,))
        h1 = Dense(64, activation="relu")(x)
        h2 = Dense(64, activation="relu")(h1)
        h3 = Dense(64, activation="relu")(h2)
        out = Dense(10, activation="softmax")(h3)
        model = Model(inputs=x, outputs=out)
        return model

    def compile(self):
        # Компіляція моделі
        optimizer = Adam(learning_rate=self.learning_rate)
        self.model.compile(
            optimizer=optimizer,
            loss=sparse_categorical_crossentropy,
            metrics=[sparse_categorical_accuracy],
        )

    def train(self, X_train, Y_train, X_test, Y_test, batch_size=64, epochs=10):
        # Тренування моделі
        self.model.fit(
            X_train,
            Y_train,
            batch_size=batch_size,
            epochs=epochs,
            validation_data=(X_test, Y_test),
        )

    def predict(self, X):
        # Передбачення класів для тестових даних
        return self.model.predict(X)


# Клас для візуалізації результатів
class Visualizer:
    @staticmethod
    def visualize_predictions(X_test, Y_test, predictions, num_samples=5):
        # Візуалізація кількох випадкових зразків з передбаченнями
        random_indices = np.random.choice(len(X_test), num_samples, replace=False)

        for index in random_indices:
            actual_image = X_test[index].reshape(28, 28) * 10  # Повертаємо масштаб зображення
            plt.imshow(actual_image, cmap="gray")
            plt.title(f"Actual: {Y_test[index]}, Predicted: {np.argmax(predictions[index])}")
            plt.show()


# Основна частина програми
if __name__ == "__main__":
    # Ініціалізація завантажувача даних
    data_loader = DataLoader("mnist_train.csv", "mnist_test.csv")
    data_loader.load_data()
    X_train, Y_train, X_test, Y_test = data_loader.get_data()

    # Ініціалізація та тренування моделі
    classifier = DigitClassifier(input_shape=784, learning_rate=0.001)
    classifier.compile()
    classifier.train(X_train, Y_train, X_test, Y_test, batch_size=64, epochs=10)

    # Робимо передбачення
    predictions = classifier.predict(X_test)

    # Виводимо результати передбачень
    for real, predicted in zip(Y_test[:5], predictions[:5]):
        max_index = np.argmax(predicted)
        print(f"Value {real} was predicted as {max_index}")

    # Візуалізуємо деякі передбачення
    visualizer = Visualizer()
    visualizer.visualize_predictions(X_test, Y_test, predictions, num_samples=5)

