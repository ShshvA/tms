Console.Write("Введите целочисленное число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целочисленное число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"Введенные числа: a = {a}, b = {b}");

Console.WriteLine();

Console.WriteLine($"Сумма a + b = {a + b}");
Console.WriteLine($"Разность a - b = {a - b}");
Console.WriteLine($"Произведение a * b = {a * b}");
Console.WriteLine($"Деление a / b, без приведения типов = {a / b}");
Console.WriteLine($"Деление a / b, с приведением типов = {((float)a / b):f2}");
Console.WriteLine($"Остаток от деление a % b = {a % b}");

Console.WriteLine();

int c = a;
Console.WriteLine($"Постфиксный инкремент a++ : a = {c++}");
Console.WriteLine($"Новое значение после инкремента: a  = {c}");
Console.WriteLine();
c = a;
Console.WriteLine($"Префиксный инкремент ++a : a = {++c}");
Console.WriteLine($"Новое значение после инкремента: a  = {c}");
Console.WriteLine();
c = a;
Console.WriteLine($"Постфиксный декремент a-- : a = {c--}");
Console.WriteLine($"Новое значение после декремента: a  = {c}");
Console.WriteLine();
c = a;
Console.WriteLine($"Префиксный декремент --a : a = {--c}");
Console.WriteLine($"Новое значение после декремента: a  = {c}");
Console.WriteLine();

Console.WriteLine($"Возведение в степень: {a}^{b} = {Math.Pow(a, b):f2}");
Console.WriteLine($"Квадратный корень из числа а: {Math.Sqrt(a):f2}");
Console.WriteLine($"Модуль разности: |{a} - {b}| = {Math.Abs(a - b)}");