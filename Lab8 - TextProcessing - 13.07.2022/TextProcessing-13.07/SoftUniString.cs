using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessing_13._07
{
    internal class SoftUniString
    {
        private char[] array;
        private int index = 0;

        public SoftUniString()
        {
            array = new char[4];

        }

        public void Append(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                array[index++] = text[i];
                Resize();
            }
        
        }

        private void Resize()
        {
            if (index >= array.Length)
            {
                var newArray = new char[array.Length * 2];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }

                array = newArray;
            }
        }

        public override string ToString()
        {

            return new string(array);
        }
    }
}
