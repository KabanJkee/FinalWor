/*
Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести 
с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше 
обойтись исключительно массивами.
*/

            string[] array;
            Console.WriteLine("Введите массив строк через пробел");
            string input = Console.ReadLine();
            array = input.Split(' ');
            string [] result = new string[array.Length];
            int i = 0;
            foreach (string value in array)
            {
                if (value.Length <= 3)
                {
                    result[i] = value;
                    i++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(Environment.NewLine, result, 0, i));
