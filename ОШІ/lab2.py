import operator
import math
import random
import numpy as np
from deap import algorithms, base, creator, tools, gp
from functools import partial

# Клас для кастомної операції ділення
class DivisionOperator:
    @staticmethod
    def division_operator(numerator, denominator):
        # Виконує ділення з перевіркою, щоб уникнути ділення на нуль.
        # Якщо знаменник дорівнює нулю, повертаємо 1, щоб уникнути помилки.
        return numerator / denominator if denominator != 0 else 1

# Клас, що містить метод для оцінки функції
class Evaluator:
    @staticmethod
    def eval_func(individual):
        x, y, z = individual
        mse = 1 / (1 + (x - 2) ** 2 + (y + 1) ** 2 + (z - 1) ** 2)
        return mse,  # Повертаємо значення як ви просили

# Клас, що налаштовує інструменти для DEAP
class ToolboxConfigurator:
    @staticmethod
    def create_toolbox():
        # Створення класу для максимізації функції, що намагається досягти найвищого значення оцінки.
        creator.create("FitnessMax", base.Fitness, weights=(1.0,))
        # Створення класу для особин, які є списками чисел.
        creator.create("Individual", list, fitness=creator.FitnessMax)

        # Ініціалізація базового інструментарію для налаштування еволюційного алгоритму.
        toolbox = base.Toolbox()
        # Реєструємо метод для створення випадкового числа у діапазоні [-10, 10].
        toolbox.register("attr_float", random.uniform, -10, 10)
        # Реєструємо метод для створення особини з трьома випадковими числами (x, y, z).
        toolbox.register("individual", tools.initRepeat, creator.Individual, toolbox.attr_float, n=3)
        # Реєструємо метод для створення популяції з набору особин.
        toolbox.register("population", tools.initRepeat, list, toolbox.individual)
        # Реєструємо метод для оцінки особин за допомогою eval_func.
        toolbox.register("evaluate", Evaluator.eval_func)
        # Реєструємо метод для схрещування двох особин (cxBlend).
        toolbox.register("mate", tools.cxBlend, alpha=0.5)
        # Реєструємо метод для мутації особин, де мутація додає випадкове значення до елементів.
        toolbox.register("mutate", tools.mutGaussian, mu=0, sigma=1, indpb=0.2)
        # Реєструємо метод для відбору особин на основі турнірного відбору.
        toolbox.register("select", tools.selTournament, tournsize=3)

        return toolbox  # Повертаємо налаштований toolbox.

# Клас для управління процесом еволюції
class EvolutionaryAlgorithm:
    def __init__(self, toolbox, population_size=2, generations=50):
        self.toolbox = toolbox
        self.population_size = population_size  # Розмір початкової популяції.
        self.generations = generations  # Кількість поколінь, протягом яких буде проходити еволюція.
        # Створення початкової популяції із заданою кількістю особин.
        self.population = toolbox.population(n=self.population_size)
        # Ініціалізація списку для збереження значень максимумів для кожного покоління.
        self.max_history = []

    def run(self):
        # Запускає процес еволюції для заданої кількості поколінь.
        for gen in range(self.generations):
            # Виконує еволюцію для одного покоління з заданими параметрами.
            algorithms.eaMuPlusLambda(
                self.population,  # Поточна популяція.
                self.toolbox,  # Набір інструментів для схрещування, мутації, оцінки.
                mu=10,  # Кількість особин, які залишаються у популяції після відбору.
                lambda_=40,  # Кількість нових особин, які додаються у популяцію.
                cxpb=0.7,  # Імовірність схрещування.
                mutpb=0.2,  # Імовірність мутації.
                ngen=1,  # Кількість поколінь (по одному за цикл).
                stats=None,  # Немає додаткової статистики.
                halloffame=None,  # Немає збереження найкращих особин.
                verbose=False  # Вимкнено виведення проміжних результатів.
            )

            # Вибір найкращої особини в поточному поколінні за значенням оцінки.
            best_individual = tools.selBest(self.population, k=1)[0]
            best_values = best_individual.fitness.values
            # Розрахунок інверсії оцінки для отримання максимального значення.
            max_fitness = 1 / best_values[0]
            self.max_history.append(max_fitness)  # Додаємо значення в історію максимумів.

            # Виведення інформації про поточне покоління і його найкращу особину.
            print(f"Покоління {gen + 1}, Знайдений максимум: {max_fitness}")
            print("Параметри x, y, z:", best_individual)

# Основна частина програми
if __name__ == "__main__":
    random.seed(7)  # Ініціалізація генератора випадкових чисел для відтворюваних результатів.
    toolbox = ToolboxConfigurator.create_toolbox()  # Створення налаштованого toolbox.
    evolutionary_algorithm = EvolutionaryAlgorithm(toolbox)  # Ініціалізація еволюційного алгоритму з toolbox.
    evolutionary_algorithm.run()  # Запуск процесу еволюції.