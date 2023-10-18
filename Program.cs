// using System;

// class Program
// {
//     static void PrintNaturalNumbers(int n)
//     {
//         if (n < 1)
//             return;

//         Console.WriteLine(n);
//         PrintNaturalNumbers(n - 1);
//     }

//     static void Main()
//     {
//         Console.Write("Введите значение N: ");
//         int N = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine($"Натуральные числа от {N} до 1:");
//         PrintNaturalNumbers(N);
//     }
// }





// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите значение M: ");
//         int M = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение N: ");
//         int N = int.Parse(Console.ReadLine());

//         int sum = CalculateSum(M, N);

//         Console.WriteLine("Сумма натуральных чисел в промежутке от {0} до {1} равна {2}", M, N, sum);
//     }

//     static int CalculateSum(int m, int n)
//     {
//         if (m > n)
//             return 0;
//         else
//             return m + CalculateSum(m + 1, n);
//     }
// }




// using System;

// class Program
// {
//     static int Ackermann(int m, int n)
//     {
//         if (m == 0)
//             return n + 1;
//         else if (m > 0 && n == 0)
//             return Ackermann(m - 1, 1);
//         else
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//     }

//     static void Main()
//     {
//         Console.Write("Введите значение m: ");
//         int m = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Введите значение n: ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         int result = Ackermann(m, n);

//         Console.WriteLine($"Значение функции Аккермана для m={m} и n={n} равно {result}");
//     }
// }
