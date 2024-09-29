// Определение класса MidpointRectangleCalculator, который реализует интерфейс ICalculatorIntegral
using WPFIntegral_347_2024.Classes;

public class MidpointRectangleCalculator : ICalculatorIntegral
{
    // Метод Calculate, который вычисляет интеграл функции func на интервале [lower, upper] с помощью метода среднего прямоугольника
    public double Calculate(double lower, double upper, int count, Func<double, double> func)
    {
        // Вычисление ширины каждой части интервала (h = (upper - lower) / count)
        double h = (upper - lower) / count;

        // Инициализация переменной sum, которая будет хранить сумму значений функции в средних точках частей
        double sum = 0.0;

        // Цикл, который проходит по всем частям интервала
        for (int i = 0; i < count; i++)
        {
            // Вычисление средней точки текущей части (midpoint = lower + (i + 0.5) * h)
            double midpoint = lower + (i + 0.5) * h;

            // Добавление значения функции в средней точке к сумме
            sum += func(midpoint);
        }

        // Возвращение результата интеграла (h * sum)
        return h * sum;
    }
}