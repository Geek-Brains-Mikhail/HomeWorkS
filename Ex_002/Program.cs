// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Request(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine()); 
}
double[] CoordinatesXY(double b1,double k1,double b2, double k2,double[] arr)
{
    arr[0]= (b2 - b1) / (k1 - k2);
    arr[1]= k1 * arr[0] + b1;
    return arr;
}
double b1 = Request("Введите значение b1: ");
double k1 = Request("Введите значение k1: ");
double b2 = Request("Введите значение b2: ");
double k2= Request("Введите значение k2: ");
double[] resultXY  = new double[2];
resultXY = CoordinatesXY(b1,k1,b2,k2,resultXY);
Console.WriteLine($"Точка пересечений двух прямых({resultXY[0]};{resultXY[1]})");

