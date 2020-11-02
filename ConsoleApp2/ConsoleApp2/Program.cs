using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = null;
            int size = -1;
            bool ok = false;
            string menu = "-1";
            do
            {
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("1. Сформировать массив.");
                Console.WriteLine("2. Удалить нечётные элементы.");
                Console.WriteLine("3. Добавление K элементов в начало массива.");
                Console.WriteLine("4. Распечатать массив.");
                Console.WriteLine("0. Выход.");
                Console.Write("Выберите пункт меню: ");
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        Console.Write("Введите размер массива: ");
                        try
                        {
                            size = int.Parse(Console.ReadLine());
                            if (size <= 0)
                            {
                                if (size == 0)
                                    Console.WriteLine("Пустой массив!");
                                else Console.WriteLine("Введено отрицательное число!");
                                ok = false;
                            }
                            else ok = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ошибка! Вы ввели не число.");
                            ok = false;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ошибка! " + e.Message);
                            ok = false;
                        }
                        finally
                        {
                            if (!ok)
                                size = 0;
                        }
                        if (size != 0)
                        {
                            arr = new int[size];
                            Console.WriteLine("Введите элементы массива:");
                            for (int i = 0; i < size; i++)
                            {
                                Console.Write("№" + (i + 1) + ": ");
                                // здесь нет проверки ввода
                                arr[i] = int.Parse(Console.ReadLine());
                            }
                            Console.WriteLine("Исходный массив:");
                            for (int i = 0; i < size; i++)
                                Console.Write(arr[i] + " ");
                            Console.WriteLine();
                        }
                        else Console.WriteLine("Пустой массив!");
                        ; break;
                    case "2":
                        if (size >= 0)
                        {
                            int count = 0;
                            for (int i = 0; i < size; i++)
                            {
                                if (arr[i] % 2 == 0)
                                    count++;
                            }
                            if (count != size)
                            {
                                int[] temp = new int[count];
                                int j = 0;
                                for (int i = 0; i < size; i++)
                                    if (arr[i] % 2 == 0)
                                    {
                                        temp[j] = arr[i];
                                        j++;
                                    }
                                arr = temp; // ссылка
                                size = count; // значение
                                if (size != 0)
                                {
                                    Console.WriteLine("Массив после удаления нечётных элементов:");
                                    for (int i = 0; i < size; i++)
                                        Console.Write(arr[i] + " ");
                                    Console.WriteLine();
                                }
                                else Console.WriteLine("Массив стал пустым!");
                            }
                            else
                                Console.WriteLine("В массиве нет нечётный элементов! Он остался без изменений.");
                            ;
                        }
                        else
                            Console.WriteLine("Массив не сформирован.");
                        break;
                    case "3":
                        if (size >= 0)
                        {
                            Console.Write("Введите количество добавляемых элементов в начало массива: ");
                            int K = int.Parse(Console.ReadLine());
                            if (K != 0)
                            {
                                Random rnd = new Random();
                                int[] temp = new int[size + K];
                                for (int i = 0; i < size + K; i++)
                                {
                                    if (i < K)
                                        temp[i] = rnd.Next(-9, 11);
                                    else
                                        temp[i] = arr[i - K];
                                }
                                arr = temp; // ссылка
                                size += K; // значение
                                Console.WriteLine("Массив после добавления " + K + " элементов в начало массива:");
                                for (int i = 0; i < size; i++)
                                    Console.Write(arr[i] + " ");
                                Console.WriteLine();
                            }
                            else
                                Console.WriteLine("В массив ничего не добавляется! Он остался без изменений.");
                        }
                        else Console.WriteLine("Массив не сформирован, добавление невозможно!");
                        break;
                    case "4":
                        if (size >= 0)
                        {
                            for (int i = 0; i < size; i++)
                                Console.Write(arr[i] + " ");
                            Console.WriteLine();
                        }
                        else Console.WriteLine("Массив не сформирован, добавление невозможно!");
                        break;
                    case "0": Console.WriteLine("Программа завершена!"); break;
                    default:
                        Console.WriteLine("Такой команды не существует! Повторите ввод!"); break;
                }

            } while (menu != "0");





            //int[] mas = new int[5];
            //int[] mas1 = { 1, 2, 3, 4, 5 };

            /*
            Console.WriteLine(int.MaxValue);

            

            if (size != 0)
            {
                
                // Console.WriteLine("Здесь будем заполнять массив...");
                for (int i = 0; i < 5; i++)
                    Console.Write(mas[i] + " ");
                Console.WriteLine();
                for (int i = 0; i < 5; i++)
                    Console.Write(mas1[i] + " ");
                Console.WriteLine();
                //for (int i = -1; i < 5; i++)
                //    Console.Write(mas1[i] + " ");
                //Console.WriteLine();
                */


            // Удаление нечётных элементов





            /*
            int[] arr_rnd = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
                arr_rnd[i] = rnd.Next(-9, 11);
            for (int i = 0; i < size; i++)
                Console.Write(arr_rnd[i] + " ");
            Console.WriteLine();
            

        }
*/
            Console.ReadLine();
        }
    }
}
