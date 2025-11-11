int a = GetInputValue("Введите целочисленное число a: ");
int b = GetInputValue("Введите целочисленное число b: ");

Console.WriteLine($"\nВведенные числа: a = {a}, b = {b}");

PrintBasicOperations(a, b);
PrintIncrementOperations(a, b);
PrintMathOperation(a, b);
PrintBitwiseOperations(a, b);
int GetInputValue(string message)
{
    while(true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int result))
            return result;
        else
            Console.WriteLine("Ошибка ввода. Введите целочисленное число.");

    }
}
void PrintBasicOperations(int a, int b)
{
    Console.WriteLine("\nАрифметические операции:");
    Console.WriteLine($"\tСумма a + b = {a + b}");
    Console.WriteLine($"\tРазность a - b = {a - b}");
    Console.WriteLine($"\tПроизведение a * b = {a * b}");
    Console.WriteLine($"\tДеление a / b, без приведения типов = {a / b}");
    Console.WriteLine($"\tДеление a / b, с приведением типов = {(float)a / b:F2}");
    Console.WriteLine($"\tОстаток от деление a % b = {a % b}");
}
void PrintIncrementOperations(int a, int b)
{
    Console.WriteLine("\nОперации инкремента и декремента:");
    int c = a, d = b;
    Console.WriteLine($"\tПостфиксный инкремент a++ : a = {c++}");
    Console.WriteLine($"\tНовое значение после инкремента: a  = {c}\n");
    c = a;
    Console.WriteLine($"\tПрефиксный инкремент ++a : a = {++c}");
    Console.WriteLine($"\tНовое значение после инкремента: a  = {c}\n");
    c = a;
    Console.WriteLine($"\tПостфиксный декремент a-- : a = {c--}");
    Console.WriteLine($"\tНовое значение после декремента: a  = {c}\n");
    c = a;
    Console.WriteLine($"\tПрефиксный декремент --a : a = {--c}");
    Console.WriteLine($"\tНовое значение после декремента: a  = {c}\n");

    c = a; d = b;
    Console.WriteLine($"\tЗначение выражения 2 * a++ + ( b-- - 1 ) = {2 * c++ + (d-- - 1)}");
    c = a; d = b;
    Console.WriteLine($"\tЗначение выражения 2 * ++a + ( --b - 1 ) = {2 * ++c + (--d - 1)}");
}
void PrintMathOperation(int a, int b)
{
    Console.WriteLine("\nМатематические операции:");
    Console.WriteLine($"\tВозведение в степень: {a}^{b} = {Math.Pow(a, b):F2}");
    if (a >= 0)
        Console.WriteLine($"\tКвадратный корень из числа a: {Math.Sqrt(a):F2}");
    else
        Console.WriteLine($"\tКвадратный корень из отрицательного числа {a} не вычисляется");
    Console.WriteLine($"\tМодуль разности: |{a} - {b}| = {Math.Abs(a - b)}");
}
void PrintBitwiseOperations(int a, int b)
{
    Console.WriteLine("\nПобитовые операции:");
    Console.WriteLine($"\tБитовый сдвиг a << 1 = {a << 1}");
    Console.WriteLine($"\tБитовый сдвиг a >> 1 = {a >> 1}");
    Console.WriteLine($"\tПобитовое И a & b = {a & b}");
    Console.WriteLine($"\tПобитовое ИЛИ a | b = {a | b}");
    Console.WriteLine($"\tПобитовое исключающее ИЛИ a ^ b = {a ^ b}");
}