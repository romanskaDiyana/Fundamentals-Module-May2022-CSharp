using System;
using System.Text;

namespace TextProcessing_13._07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Text Processing
            //01.String - колекция от чарове, масиви - не може да се променя големината;
            //02.Конкатенцаия с "+", долепяне на един string до друг string;
            //03.Стринговете са read-only, защото са масиви;
            //04.Index Of - винаги връща индекса на първия;
            //ако искаме да върне друг индекс, задаваме start index, търси цял substring;
            //05.Index Of - връща началото на string-а, който търсим, ако не съществува връща -1;
            //06.Substring - голям string - части от големия string. 
            //07.LastIndexOf() - връща последният индекс, началото на елемента;
            //08.Substring - изличане на substring от string;
            //09.Contains - връща true,false

            //--------------------------------------------------//
            //string text = "Lorem ipsum"; //Lorem ipsum е един от най-често
            //използваните в печатарството и графичния
            //дизайн заготовъчни текстове,
            //служещи да запълват с текст онези графични
            //елементи на документ или графична презентация,
            //които трябва да бъдат представени със собствен
            //шрифт и типография, запълвайки ги със стандартен,
            //неотвличащ вниманието безсмислен текст.

            //-----------------------------------------//

            //string.Concat(type,type) - конкатенация;

            //----------------------------------------------------//
            //string text = Console.ReadLine();

            //int firstSecondJavaIndex = (text.IndexOf("java"));
            //int secondJavaIndex = (text.IndexOf("java", firstSecondJavaIndex + 1));

            //if (secondJavaIndex >= 0)
            //{
            //    Console.WriteLine("Java Found");
            //    Console.WriteLine(firstSecondJavaIndex);
            //}
            //else
            //{
            //    Console.WriteLine("No Java");
            //}

            //---------------------------------------------------//
            //string text = "Substrings are cool";
            //string first3 = text.Substring(3, 3); //без втори параметър - връща до края;

            //Console.WriteLine(first3); //взимане на елементи - по индекси;

            //------------------------------------------------//

            //Split By String

            //string text = "Loren ipsum, hello! How are you, I am fine, You?";

            //string[] splited = text.Split(new string[] {",", "!", ".", " "}, StringSplitOptions.RemoveEmptyEntries);      
            //Console.WriteLine(text);

            //foreach (var item in splited)
            //{
            //    Console.WriteLine(item);
            //}

            //------------------------------------------------------//

            //StringBuilder

            //има неограничена големина;
            //не локира памет;

            
            //StringBuilder text = new StringBuilder();

            //text.Append("Hello");
            //text.AppendLine(" ");
            //text.Append("You");

            //Console.WriteLine(text);

            //--------------------------------------------------------//
                
            //String Builder - CREATE - при степени на двойката, а string всеки път;

            SoftUniString softUniString = new SoftUniString();

            softUniString.Append("SoftUni");
            softUniString.Append("Hello");

            Console.WriteLine(softUniString);
            






















        }
    }
}
