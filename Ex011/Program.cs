// Урок 6. Одномерные массивы. Продолжение
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// логика такая - пользователь вводит в консоль сколько угодно чисел через пробел (в пределах разумного)
// программа будет преобразовывать эту строку в массив из целых чисел
// int[] FillArray(string text) // функция которая получает из строки массив с целыми числами
// {
//     int lengthArray = 0; // вводим пременную lengthArray, в итоге она будет равна размеру массива,
//                            // который получится из чисел которые вводит пользователь в консоли
//     int[] array = new int[1000]; // задаем массив размерность 1000, так как мы не знаем сколько знаков введет пользователь
//                                   // берем заведомо большое число, чтобы вместить все знаки введенные пользователем
//     string textNumber = "";     // введем временную строковую переменную textNumber, она будет хранить все символы одного числа
//     for (int i = 0; i < text.Length; i++) // переберем в цикле все элементы строки
//     {
//         if (i == 0 && text[i] == ' ') continue; // условие если первый символ в строке - пробел
//         if (text[i] == ' ' && !(text[i-1] == ' ')) // условие того что текущий символ пробел, а предыдущий непробел
//         {                                             // это означает что число закончилось на предыдущем шаге
//             lengthArray++;                         // увеличиваем переменную lengthArray на 1,
//                                                     // так как добавился еще один элемент в массив
//             array[lengthArray-1] = int.Parse(textNumber);  // введем наш полученный элемент массив
//             textNumber = "";  // обнулим нашу переменную textNumber, так как в нее теперь будем собирать следующий элемент
//             continue;        // прерываем текущий шаг цикла и переходим на следующий
//         }
//         else if (text[i] == ' ' && text[i-1] == ' ') continue; // условие того что текущий и предыдущий символы - пробелы
//                                           // означает что ввели лишний пробел - ничего не делаем переходим на след. шаг
//         else if (!(text[i] == ' '))     // условие того что текущ элемент не пробел
//         {            
//             textNumber = textNumber + Convert.ToString(text[i]); // добавляем текущ элемент к перем textNumber
//             if (i < text.Length - 1) continue;  // это условие что i не последнее в цикле
//         }
//         lengthArray++;              // увеличиваем переменную lengthArray на 1,
//                                        // так как добавился еще один элемент в массив
//                                           // актуально для последнего элемента в цикле
//         array[lengthArray-1] = int.Parse(textNumber);  // введем наш полученный элемент массив             
//     }  
//     int[] array2 = new int[lengthArray]; // введем второй массив для того чтобы в нем бвло правильное количество элементов
//     for (int j = 0; j < lengthArray; j++) // и в цикле присвоим второму массиву все найденные элемнты из начального массива
//     {
//         array2[j] = array[j];
//     }
//     return array2; // функция вернет второй массив
// }
// void PrintArray(int[] array) // функция которая выводит в консоль массив
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// int positiveNumbers(int[] array) // функция которая считает количество элементов больших 0 в массиве
// {
//     int number = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) number++;
//     }
//     return number;
// }
// Console.WriteLine("Введите целые числа через пробел и нажмите Enter: "); // запрашиваем у пользователя ввода чисел
// string textOfConsole = Console.ReadLine();
// int[] array = FillArray(textOfConsole); // вызываем функцию которая переводит строку в массив из чисел
// Console.WriteLine();
// PrintArray(array);  // печатаем полученный массив в консоль
// Console.WriteLine();
// Console.WriteLine($"{positiveNumbers(array)} чисел больше 0 "); // выводим полученный результат в консоль
// Console.WriteLine();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// вариант 1 - задание параметров пользоваителем через консоль
// double[] intersectionPoint(int k1, int k2, int b1, int b2) // функция которая находит точку пересечение двух прямых
// {                                                          // зная их параметры k1, k2, b1, b2
//     double[] point = new double[2];  // для хранения точки пересечения будем использовать массив состоящий из 2 элементов
//     double x = b2 - b1;             // используем формулу нахождения координат пересечения прямых x = (b2 - b1) / (k1 - k2)
//     double del = k1 - k2;
//     x = x / del;
//     point[0] = x;              
//     double y = k1 * x + b1;        // подставляем полученное x в одно из уравнений прямой и получаем y - вторую координату точки
//     point[1] = y;
//     return point;                 // передаем наши x и y в массив point
// }
// void PrintLines(int a, int b, int c, int d) // функция которая выводит полученные прямые
// {
//     string sign1 = "-";
//     string sign2 = "-";
//     if (c>=0) sign1 = "+";
//     if (d>=0) sign2 = "+";
//     Console.WriteLine();
//     Console.WriteLine("Полученные прямые :");
//     Console.WriteLine($"Первая прямая: Y = {a}*X {sign1} {Math.Abs(c)}");
//     Console.WriteLine($"Вторая прямая: Y = {b}*X {sign2} {Math.Abs(d)}");
//     Console.WriteLine();
// }
// Console.WriteLine("Введите параметры прямых y = k1*x + b1 и y = k2*x + b2: ");
// Console.Write("Введите параметр k1: ");
// int k1 = int.Parse(Console.ReadLine());
// Console.Write("Введите параметр b1: ");
// int b1 = int.Parse(Console.ReadLine());
// Console.Write("Введите параметр k2: ");
// int k2 = int.Parse(Console.ReadLine());
// Console.Write("Введите параметр b2: ");
// int b2 = int.Parse(Console.ReadLine());

// PrintLines(k1, k2, b1, b2); // выводим в консоль как выглядят наши уравнения прямых
// if (k1 == k2) // проверяем условие параллельности наших прямых - если k1 = k2 - прямые параллельны
// {
//     Console.WriteLine($"Точки пересечения нет, так как угловые коэффициэнты равны k1 = k2 = {k1}, прямые параллельны");
// }
// else // иначе находим точку пересечения и выводим ее значение в консоль
// {
//     double[] point = intersectionPoint(k1, k2, b1, b2);
//     Console.WriteLine($"Точка пересечения этих прямых: M ( {point[0]}, {point[1]} )");
// }

// Console.WriteLine();

// ---------------

// вариант 2 - ввод параметров ранодмно без участия пользователя
double[] intersectionPoint(int k1, int k2, int b1, int b2)
{
    double[] point = new double[2];
    double x = b2 - b1;
    double del = k1 - k2;
    x = x / del;
    point[0] = x;
    double y = k1 * (b2 - b1) / (k1 - k2) + b1;
    point[1] = y;
    return point;
}
void PrintLines(int k1, int k2, int b1, int b2) // функция которая выводит полученные прямые
{
    string sign1 = "-";
    string sign2 = "-";
    if (b1>=0) sign1 = "+";
    if (b2>=0) sign2 = "+";
    Console.WriteLine();
    Console.WriteLine("Полученные прямые :");
    Console.WriteLine($"Первая прямая: Y = {k1}*X {sign1} {Math.Abs(b1)}");
    Console.WriteLine($"Вторая прямая: Y = {k2}*X {sign2} {Math.Abs(b2)}");
    Console.WriteLine();
}
// отличия от варианта 1 только тут - параметры вводятся при помощи new Random().Next(min, max)
int k1 = new Random().Next(-10, 11);
int k2 = new Random().Next(-10, 11);
int b1 = new Random().Next(-10, 11);
int b2 = new Random().Next(-10, 11);

PrintLines(k1, k2, b1, b2);
if (k1 == k2)
{
    Console.WriteLine($"Точки пересечения нет, так как угловые коэффициэнты равны k1 = k2 = {k1}, прямые параллельны");
}
else
{
    double[] point = intersectionPoint(k1, k2, b1, b2);
    Console.WriteLine($"Точка пересечения этих прямых: M ( {point[0]}, {point[1]} )");
}
Console.WriteLine();