import numpy as np
import matplotlib.pyplot as plt
from sklearn import metrics
from sklearn.cluster import KMeans, MeanShift, estimate_bandwidth

class ClusterAnalysis:
    DEFAULT_DELIMITER = ','
    def __init__(self, data_file, delimiter=','):
        # Завантаження даних з файлу
        self.X = np.loadtxt(data_file, delimiter=delimiter)
        # Ініціалізація змінних для ширини пропускання та моделей кластеризації
        self.bandwidth_X = None
        self.meanshift_model = None
        self.kmeans_model = None
        self.cluster_centers = None
        self.labels = None
        self.num_clusters = None
        self.scores = []  # Список для збереження оцінок силуету

    def plot_input_data(self, color='gray', facecolor='black', title='INPUT DATA'):
        # Відображення вихідних точок на графіку
        plt.figure()
        plt.scatter(self.X[:, 0], self.X[:, 1], color=color, s=80, marker='o', facecolors=facecolor)
        # Визначення меж для графіка
        x_min, x_max = self.X[:, 0].min() - 1, self.X[:, 0].max() + 1
        y_min, y_max = self.X[:, 1].min() - 1, self.X[:, 1].max() + 1
        # Налаштування параметрів графіка
        plt.title(title)  # Назва графіка
        plt.xlim(x_min, x_max)  # Встановлення меж по осі X
        plt.ylim(y_min, y_max)  # Встановлення меж по осі Y
        plt.xticks(())  # Вимкнення поділок по осі X
        plt.yticks(())  # Вимкнення поділок по осі Y

    def fit_meanshift(self):
        # Оцінка ширини пропускання для алгоритму MeanShift
        self.bandwidth_X = estimate_bandwidth(self.X, quantile=0.15, n_samples=len(self.X))
        # Створення та навчання моделі MeanShift
        self.meanshift_model = MeanShift(bandwidth=self.bandwidth_X, bin_seeding=True)
        self.meanshift_model.fit(self.X)
        # Збереження центрів кластерів та міток
        self.cluster_centers = self.meanshift_model.cluster_centers_
        self.labels = self.meanshift_model.labels_
        # Підрахунок кількості кластерів
        self.num_clusters = len(np.unique(self.labels))
        # Виведення результатів
        print('\nCenters of clusters:\n', self.cluster_centers)
        print("\nNumber of clusters in input data =", self.num_clusters)

    def plot_meanshift_clusters(self, color='purple', markerfacecolor='red', markeredgecolor='black', title='Clusters'):
        # Відображення кластерів, знайдених за допомогою MeanShift
        plt.figure()
        markers = 'o*xvsd<'  # Різні маркери для кожного кластеру
        # Відображення точок та центрів кластерів
        for i, marker in zip(range(self.num_clusters), markers):
            plt.scatter(self.X[self.labels == i, 0], self.X[self.labels == i, 1], marker=marker, color=color)
            cluster_center = self.cluster_centers[i]
            plt.plot(cluster_center[0], cluster_center[1],
                     marker='o',
                     markerfacecolor=markerfacecolor,
                     markeredgecolor=markeredgecolor,
                     markersize=15)
        plt.title(title)  # Назва графіка

    def evaluate_kmeans(self, range_values):
        # Оцінка якості кластеризації для різної кількості кластерів з використанням KMeans
        for num_clusters in range_values:
            # Створення та навчання моделі KMeans
            kmeans = KMeans(init='k-means++', n_clusters=num_clusters, n_init=10)
            kmeans.fit(self.X)
            # Розрахунок оцінки силуету для поточної моделі
            score = metrics.silhouette_score(self.X, kmeans.labels_, metric='euclidean', sample_size=len(self.X))
            # Виведення результатів оцінки
            print("\nNumber of clusters =", num_clusters)
            print("Silhouette score =", score)
            # Додавання оцінки до списку
            self.scores.append(score)

    def plot_silhouette_scores(self, range_values, color='gray', title='Silhouette score vs number of clusters'):
        # Відображення оцінок силуету для різної кількості кластерів
        plt.figure()
        plt.bar(range_values, self.scores, width=0.5, color=color, align='center')
        plt.title(title)  # Назва графіка

    def fit_kmeans(self, num_clusters):
        # Створення та навчання моделі KMeans з заданою кількістю кластерів
        self.kmeans_model = KMeans(init='k-means++', n_clusters=num_clusters, n_init=10)
        self.kmeans_model.fit(self.X)

    def plot_kmeans_boundaries(self, edgecolors='black', color='black', facecolors='black', title='Boundaries of clusters'):
        # Відображення меж кластерів, знайдених за допомогою KMeans
        step_size = 0.1  # Розмір кроку для сітки
        # Визначення меж для сітки
        x_min, x_max = self.X[:, 0].min() - 1, self.X[:, 0].max() + 1
        y_min, y_max = self.X[:, 1].min() - 1, self.X[:, 1].max() + 1
        x_vals, y_vals = np.meshgrid(np.arange(x_min, x_max, step_size), np.arange(y_min, y_max, step_size))
        # Передбачення міток для точок сітки
        output = self.kmeans_model.predict(np.c_[x_vals.ravel(), y_vals.ravel()])
        output = output.reshape(x_vals.shape)

        # Відображення кольорових областей кластерів
        plt.figure()
        plt.clf()  # Очищення поточного графіка
        plt.imshow(output, interpolation='nearest', extent=(x_vals.min(), x_vals.max(), y_vals.min(), y_vals.max()),
                   cmap=plt.cm.Paired, aspect='auto', origin='lower')
        # Нанесення вихідних точок на графік
        plt.scatter(self.X[:, 0], self.X[:, 1], marker='o', facecolors='none', edgecolors=edgecolors, s=80)
        # Відображення центрів кластерів
        cluster_centers = self.kmeans_model.cluster_centers_
        plt.scatter(cluster_centers[:, 0], cluster_centers[:, 1], marker='o', s=210, linewidths=4, color=color, zorder=12, facecolors=facecolors)
        # Налаштування параметрів графіка
        plt.title(title)
        plt.xlim(x_min, x_max)
        plt.ylim(y_min, y_max)
        plt.xticks(())
        plt.yticks(())

    def show_plots(self):
        # Відображення всіх графіків
        plt.show()

if __name__ == '__main__':

    # Використання класу ClusterAnalysis для кластеризації
    cluster_analysis = ClusterAnalysis('data.txt')  # Створення об'єкта та завантаження даних
    cluster_analysis.plot_input_data()  # Відображення вихідних точок
    cluster_analysis.fit_meanshift()  # Навчання моделі MeanShift
    cluster_analysis.plot_meanshift_clusters()  # Відображення кластерів

    # Оцінка якості кластеризації для діапазону значень кількості кластерів
    cluster_analysis.evaluate_kmeans(range(2, 10))  # Оцінка для KMeans
    cluster_analysis.plot_silhouette_scores(range(2, 10))  # Відображення результатів оцінки

    # Навчання моделі KMeans з оптимальною кількістю кластерів
    cluster_analysis.fit_kmeans(cluster_analysis.num_clusters)  # Навчання моделі KMeans з кількістю кластерів з MeanShift
    cluster_analysis.plot_kmeans_boundaries()  # Відображення меж кластерів

    # Показ всіх графіків
    cluster_analysis.show_plots()
