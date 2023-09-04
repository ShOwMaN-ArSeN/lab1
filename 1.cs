using System;
using System.Text;
using System.Reflection.Metadata;
namespace project{
    class Program
    {
        static void Main(string[] args)
        {
            //1///////////////////////////////////////////////////////////////////////////
            //a)                                          
            //целочисленные типы                                  
            short shortVar = 10;
            ushort ushortVar = 20;
            byte byteVar = 30;
            sbyte sbyteVar = -30;
            int intVar = 40;
            uint uintVar = 50;
            long longVar = 60;
            //типы с плавающей точкой
            float floatVar = 3.14f;
            double doubleVar = 100.12456789;
            decimal decimalVar = 123.456789m;
            //логический тип
            bool boolVar = true;
            //символьный тип
            char charVar = 'R';
            //строковый тип
            string stringVar = "Hello, world!";
            Console.WriteLine("//1///////////////////////////////////////////////////////////////////////////");
            Console.WriteLine(shortVar);
            Console.WriteLine(ushortVar);
            Console.WriteLine(sbyteVar);
            Console.WriteLine(byteVar);
            Console.WriteLine(intVar);
            Console.WriteLine(uintVar);
            Console.WriteLine(longVar);
            Console.WriteLine(floatVar);
            Console.WriteLine(doubleVar);
            Console.WriteLine(decimalVar);
            Console.WriteLine(boolVar);
            Console.WriteLine(charVar);
            Console.WriteLine(stringVar);
            //b)
            int intvalue = 100;
            double doublevalue = intvalue; //неявное привидение
            Console.WriteLine(doublevalue);
            double doublePI = 3.1415;
            int intPI = (int)doublePI; //явное привидение
            Console.WriteLine(intPI);
            //c)
            int number = 10; //значимый тип
            object boxingnumber = number; //упаковка
            int unboxingnumber = (int)boxingnumber; //распаковка
            Console.WriteLine(unboxingnumber);
            //d)
            var name = "Arseniy"; //неявно типизирована как string
            var age = 18; //неявно типизирована как int
            Console.WriteLine(name.GetType());
            Console.WriteLine(age.GetType());
            Console.WriteLine(name);
            //e)
            int? nullableInt = null;
            nullableInt = 100;
            Console.WriteLine(nullableInt);
            //f)
            // var A = 100;
            // Console.WriteLine(A);
            // var A = "r";
            // Console.WriteLine(A);
            //2///////////////////////////////////////////////////////////////////////////
            //a)
            string name1 = "Arseniy";
            string name2 = "Arseniy";
            string name3 = "Pasha";
            bool onecomparison = (name1 == name2);
            bool twocomparison = (name1 == name3);
            Console.WriteLine("//2///////////////////////////////////////////////////////////////////////////");
            Console.WriteLine(onecomparison);
            Console.WriteLine(twocomparison);
            //b)
            string str1 = "Hello, ";
            string str2 = "world!";
            string str3 = "September first month of autumn";
            Console.WriteLine(str1 + str2);//сцепление
            // string copystr3 = string.Copy(str3);//копировнаеи
            // Console.WriteLine(copystr3);
            string substring = str3.Substring(5, 10);//c 5 позиции 10 символов выделения
            Console.WriteLine(substring);
            string[] words = str3.Split(' ');//разделение строки нс слово
            foreach (string word in words){
            Console.WriteLine(word);}
            string newstr3 = str3.Insert(31, "!");//вставка подстроки
            Console.WriteLine(newstr3);
            string oldnewstr3 = newstr3.Remove(31, 1);//удаленеи подстроки
            Console.WriteLine(oldnewstr3);
            //c)
            string MyName = "";
            MyName += "Arseniy";
            bool isEmpty = (MyName == "");
            Console.WriteLine(isEmpty);
            string emptystring = ""; //пустая строка
            //string nullstring = null; //строка null
            bool examination1 = string.IsNullOrEmpty(emptystring);
            //bool examination2 = string.IsNullOrEmpty(nullstring);
            Console.WriteLine(examination1);//true
            //Console.WriteLine(examination2);
            //d)
            StringBuilder MyStringBuilder = new StringBuilder("Random Text");
            MyStringBuilder.Remove(7, 4);
            Console.WriteLine(MyStringBuilder);
            MyStringBuilder.Insert(0, "Full ");
            Console.WriteLine(MyStringBuilder);
            MyStringBuilder.Append("Text");//добавление в конец
            Console.WriteLine(MyStringBuilder);
            //3///////////////////////////////////////////////////////////////////////////
            //a)
            Console.WriteLine("//3///////////////////////////////////////////////////////////////////////////");
            int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}};
            int rows = matrix.GetUpperBound(0) + 1;//количество строк
            int columns = matrix.Length / rows;//количество столбцов
            for (int i = 0; i < rows; i++){
                for (int j = 0; j < columns; j++){
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            //b)
            string[] fruits = { "Apple", "Banana", "Cherry"};
            Console.WriteLine("Массив:");
            foreach(string fruit in fruits){
                Console.WriteLine(fruit);
            }
            Console.WriteLine(fruits.Length);
            Console.Write("Введите цифру элемента массива, которую заменить: ");
            int input_number;
            if (int.TryParse(Console.ReadLine(), out input_number) && input_number >= 0 && input_number < fruits.Length){
                Console.Write("Введите новое значение для элемента: ");
                string? newValue = Console.ReadLine();
                fruits[input_number] = newValue;
                Console.WriteLine("Обновленный массив:");
            foreach(string fruit in fruits){
                Console.WriteLine(fruit);}
            }
            else{
            Console.WriteLine("Неверный ввод. Введите корректную цифру.");}
            //c)
            double[][] Array = new double[3][];
            //вводим значения с консоли для каждой строки
            for (int i = 0; i < Array.Length; i++){
                Console.WriteLine("Введите количество столбцов в строке:");
                int col = int.Parse(Console.ReadLine());
                Array[i] = new double[col];
                for (int j = 0; j < col; j++){
                    Console.WriteLine("Введите значение для элемента [{i}][{j}]: ");
                    Array[i][j] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Не выровненный массив:");
            for (int i = 0; i < Array.Length; i++){
                for (int j = 0; j < Array[i].Length; j++){
                    Console.Write(Array[i][j]);
                }
                Console.WriteLine();
            }
            //d
            var no_tipiz_one = new int[] { 1, 2, 3, 4, 5 };
            var no_tipiz_two = "Ars";
            Console.WriteLine(no_tipiz_two);
            //4///////////////////////////////////////////////////////////////////////////
            //a) - b) - c) - d)
            Console.WriteLine("//4///////////////////////////////////////////////////////////////////////////");
            var person = ("Arseniy", "Kurilionok", 18, 'M', 12483003572559999966);
            (string firstName, string lastName, int personage, char initial, ulong index) = person;//распаковка с использованием именованных переменных, также с не именованных переменных
            Console.WriteLine(person);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(personage);
            var personplus1 = ("Arseniy", "Kurilionok", 18);
            var personplus2 = ("Arseniy", "Kurilionok", 19);
            var (_, lastNameplus1, _) = personplus1;//пропуск ненужных значений
            Console.WriteLine(lastNameplus1);
            bool comparison = (personplus1 == personplus2);
            Console.WriteLine(comparison);
            //5///////////////////////////////////////////////////////////////////////////
            Console.WriteLine("//5///////////////////////////////////////////////////////////////////////////");
            void localfunction(){
                int A = 10;
                int B = 20;
                int C = A + B;
                Console.WriteLine(C);
            }
            localfunction();
            //6///////////////////////////////////////////////////////////////////////////
            Console.WriteLine("//6///////////////////////////////////////////////////////////////////////////");
            void localone(){
                checked{
                    int x = int.MaxValue;
                    Console.WriteLine(x + 1);//переполнение(исключение)
                }
            }
            void localtwo(){
                unchecked{
                    int y = int.MaxValue;
                    Console.WriteLine(y + 1);//минимальное значение инт
                }
            }
            localone();
            localtwo();
        }
    }
}
