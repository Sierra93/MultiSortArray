using System;
using System.Collections.Generic;

namespace MultiSortArray {
    class Program {
        static void Main() {
            int[] aArr = new int[10];
            List<int> chetListArr = new List<int>();
            List<int> nechetListArr = new List<int>();
            // Для рандома
            Random r = new Random();
            Console.WriteLine("Исходный одномерный массив");
            for (int i = 0; i < aArr.Length; i++) {
                // Заполняет рандомом
                aArr[i] = r.Next(1, 50);
                // Выводит массив
                Console.Write(aArr[i] + " ");
            }
            Console.WriteLine();
            // Явно клонирует массив aArr в массив aArrNew
            int[] aArrNew = (int[])aArr.Clone();
            // Сортирует массив по возрастанию
            Array.Sort(aArrNew);
            for (int i = 0; i < aArrNew.Length; i++) {
                // Если четные, то вставляет в один список
                if (aArrNew[i] % 2 == 0) {
                    chetListArr.Add(aArrNew[i]);
                }
                // Иначе в другой список
                else {
                    nechetListArr.Add(aArrNew[i]);
                }
            }
            Console.WriteLine();            
            // Приводит к массиву оба списка
            int[] resArrOne = chetListArr.ToArray();            
            int[] resArrTwo = nechetListArr.ToArray();
            // Выводит четные
            Console.WriteLine("Массив с четными:");
            foreach (int el in resArrOne) {                
                Console.Write(el + " ");
            }
            Console.WriteLine();
            // Выводит нечетные
            Console.WriteLine("Массив с нечетными:");
            foreach (int el in resArrTwo) {                
                Console.Write(el + " ");
            }
            Console.ReadKey();
        }
    }
}
