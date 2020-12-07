using System;
using System.Linq;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите пятизначное число \n");

            Console.ForegroundColor = ConsoleColor.Red;
            int.TryParse(Console.ReadLine(), out int Number);
            Console.WriteLine();

            int[] Array = new int[5];
            int ind;
            int tmp = 5;
            int index = 0;
            while (Number > 0)
            {
                ind = Number % 10;
                Array[index] = ind;
                Number = Number / 10;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(tmp + " число равно - " + ind + "\n");
                tmp--;
                index++;

            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Максимальное число " + Array.Max() + "\n");
            Console.WriteLine("Минимальное число " + Array.Min() + "\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Калькулятор \n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Выберите операцию \n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1. Сложение \n");

            Console.WriteLine("2. Вычитание \n");

            Console.WriteLine("3. Умножение \n");

            Console.WriteLine("4. Деление \n");

            Console.WriteLine("5. Возведение в степень \n");

            Console.WriteLine("6. Извлечение корня \n");

            int Choice;
            while (!int.TryParse(Console.ReadLine(), out Choice))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите корректное число \n");
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine();

            int Last = 0;
            int Num1 = 0;

            switch (Choice)
            {
                case 1:
                    {
                        
                        Last = Input_Sum();

                        break;
                    }

                case 2:
                    {
                       
                        Last = Input_Diff();
                        break;
                    }

                case 3:
                    {
                        
                        Last = Input_Mult();
                        break;
                    }

                case 4:
                    {
                        Last = Input_Div();
                        break;
                    }

                case 5:
                    {
                        Last = Power();
                        break;
                    }

                case 6:
                    {
                        Last = Sqrt();
                        break;
                    }
            }

            for (int i = 1; i > 0; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Для выбора действия нажмите кнопку \n");
                Console.WriteLine("Продолжить работу в калькуляторе N \n");
                Console.WriteLine("Продолжить работу с последним результатом Q \n");
                Console.WriteLine("Завершить - E \n");

                Console.ForegroundColor = ConsoleColor.Red;

                char.TryParse(Console.ReadLine(), out char Button);
                Console.WriteLine();


                if (Button == 'e')
                {
                    Console.WriteLine("Bue \n");
                    return;

                }

                if (Button == 'n')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Выберите операцию \n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("1. Сложение \n");

                    Console.WriteLine("2. Вычитание \n");

                    Console.WriteLine("3. Умножение \n");

                    Console.WriteLine("4. Деление \n");

                    while (!int.TryParse(Console.ReadLine(), out Choice))
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Введите корректное число \n");
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.WriteLine();


                    switch (Choice)
                    {
                        case 1:
                            {
                                Input_Sum();
                                break;
                            }

                        case 2:
                            {
                                Input_Diff();
                                break;
                            }

                        case 3:
                            {
                                Input_Mult();
                                break;
                            }

                        case 4:
                            Input_Div();
                            break;
                    }
                }

                if (Button == 'q')
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Выберите операцию \n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("1. Сложение \n");

                    Console.WriteLine("2. Вычитание \n");

                    Console.WriteLine("3. Умножение \n");

                    Console.WriteLine("4. Деление \n");

                    Console.WriteLine("5. Возведение в степень \n");

                    Console.WriteLine("6. Извлечение корня \n");

                    while (!int.TryParse(Console.ReadLine(), out Choice))
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Введите корректное число \n");
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.WriteLine();
                    
                    switch (Choice)
                    {
                        case 1:
                            {
                                
                                Last = Input_Summ(Last);

                                break;
                            }

                        case 2:
                            {
                                
                                Last = Input_Dif(Last);
                                break;
                            }

                        case 3:
                            {
                                
                                Last = Input_Multp(Last);
                                break;
                            }

                        case 4:
                            {
                                Last = Input_Divi(Last);
                                break;
                            }

                        case 5:
                            {
                                Last = Powers(Last);
                                break;
                            }

                        case 6:
                            {
                                Last = Sqrt1(Last);
                                break; 
                            }

                    }

                }
            }
            static int Input_Sum()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Введите слагаемое \n");
                int Num1;
                Console.ForegroundColor = ConsoleColor.Red;
                while (!int.TryParse(Console.ReadLine(), out Num1))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите корректное число \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Введите слагаемое \n");
                int Num2;
                Console.ForegroundColor = ConsoleColor.Red;
                while (!int.TryParse(Console.ReadLine(), out Num2))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите корректное число \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine();

                return Sum(Num1, Num2);
                
            }

            static int Input_Diff()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Введите уменьшаемое \n");
                int Num1;
                Console.ForegroundColor = ConsoleColor.Red;
                while (!int.TryParse(Console.ReadLine(), out Num1))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите корректное число \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Введите вычитаемое \n");
                int Num2;
                Console.ForegroundColor = ConsoleColor.Red;
                while (!int.TryParse(Console.ReadLine(), out Num2))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите корректное число \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine();

               return Diff(Num1, Num2);

                
            }

            static int Input_Mult()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Введите множитель \n");
                int Num1;
                Console.ForegroundColor = ConsoleColor.Red;
                while (!int.TryParse(Console.ReadLine(), out Num1))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите корректное число \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Введите множитель \n");
                int Num2;
                Console.ForegroundColor = ConsoleColor.Red;
                while (!int.TryParse(Console.ReadLine(), out Num2))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите корректное число \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine();

                return Mult(Num1, Num2);
 
            }

            static int Input_Div()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Введите делимое \n");
                int Num1;
                Console.ForegroundColor = ConsoleColor.Red;
                while (!int.TryParse(Console.ReadLine(), out Num1))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите корректное число \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Введите делитель \n");
                int Num2;
                Console.ForegroundColor = ConsoleColor.Red;
                while (!int.TryParse(Console.ReadLine(), out Num2))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите корректное число \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine();

                return Div(Num1, Num2);

            }

            static int Power()
            {


                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Введите возводимое число \n");
                int Num1;
                Console.ForegroundColor = ConsoleColor.Red;
                while (!int.TryParse(Console.ReadLine(), out Num1))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите корректное число \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Введите степень \n");
                int Num2;
                Console.ForegroundColor = ConsoleColor.Red;
                while (!int.TryParse(Console.ReadLine(), out Num2))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите корректное число \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine();

                return Pow(Num1, Num2);
            }

            static int Sqrt ()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Введите число \n");
                int Num1;
                int Sqrt;
                Console.ForegroundColor = ConsoleColor.Red;
                while (!int.TryParse(Console.ReadLine(), out Num1))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите корректное число \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine();

                Sqrt = (int) Math.Sqrt(Num1);

                Console.WriteLine("Корень числа = " + Sqrt + "");
                Console.WriteLine();

                return Sqrt;
            }

            static int Sum(int x, int y)
            {
                int Sum;
                Sum = x + y;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Сумма чисел = " + Sum + "\n");
                Console.ResetColor();
                return Sum;

            }

            static int Diff(int x, int y)
            {
                int Diff;
                Diff = x - y;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Разность чисел = " + Diff + "\n");
                Console.ResetColor();
                return Diff;

            }

            static int Mult(int x, int y)
            {
                int Mult;
                Mult = x * y;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Произведение чисел = " + Mult + "\n");
                Console.ResetColor();
                return Mult;
            }

            static int Div (int x, int y)
            {
                int Div;
                Div = x / y;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Частное чисел = " + Div + "\n");
                Console.ResetColor();
                return Div;
            }

            static int Pow(int x, int y)
            {
                int Pow;
                Pow = (int)Math.Pow(x, y);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Степень чисел = " + Pow + "\n");
                Console.ResetColor();
                return Pow;
            }

            static int Input_Dif(int x)
            {


                int Num1 = x;
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Уменьшаемое = " + Num1 + "\n");
                Console.WriteLine("Введите вычитаемое \n");
                int Num2;
                Console.ForegroundColor = ConsoleColor.Red;
                while (!int.TryParse(Console.ReadLine(), out Num2))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите корректное число \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine();

               return Diff(Num1, Num2);

                
            }

            static int Input_Summ(int x)
            {


                int Num1 = x;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Слагаемое = " + Num1 + "\n");
                Console.WriteLine("Введите слагаемое \n");
                int Num2;
                Console.ForegroundColor = ConsoleColor.Red;
                while (!int.TryParse(Console.ReadLine(), out Num2))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите корректное число \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine();

             return   Sum(Num1, Num2);

            }

            static int Input_Multp(int x)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;              
                int Num1 = x;
                Console.WriteLine("Множитель = " + Num1 + "\n");

                Console.WriteLine("Введите множитель \n");
                int Num2;
                Console.ForegroundColor = ConsoleColor.Red;
                while (!int.TryParse(Console.ReadLine(), out Num2))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите корректное число \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine();

              return  Mult(Num1, Num2);

            }

            static int Input_Divi(int x)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                ;
                int Num1 = x;
                Console.WriteLine("Делимое = " + Num1 + "\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Введите делитель \n");
                int Num2;
                Console.ForegroundColor = ConsoleColor.Red;
                while (!int.TryParse(Console.ReadLine(), out Num2))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите корректное число \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine();

             return  Div(Num1, Num2);

            }

            static int Powers ( int x )
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                ;
                int Num1 = x;
                Console.WriteLine("Возводимое в степень = " + Num1 + "\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Введите степень \n");
                int Num2;
                Console.ForegroundColor = ConsoleColor.Red;
                while (!int.TryParse(Console.ReadLine(), out Num2))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите корректное число \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine();

                return Pow (Num1, Num2);
            }

            static int Sqrt1 (int x)
            {
                int Num1 = x;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Число = " + Num1 + "\n");
               
                int Sqrt;
                Sqrt = (int) Math.Sqrt(x);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Корень числа = " + Sqrt + "");
                Console.WriteLine();
                Console.ResetColor();
                return Sqrt;
                

            }
        }
    }
}
                                  
    





  