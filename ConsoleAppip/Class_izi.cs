using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppip
{
    internal class stringTwo
    {
        private StringBuilder Line;
        private int n;

        private string up_words = "ABCDEFGHIKLMNOPQRSTVXYZ";
        private string low_words = "QWERTYUIOPASDFGHJKLZXCVBNM".ToLower();

        stringTwo(int len)
        {
            this.n = len;

            Line = new StringBuilder(n);
        }

        public string Value{ get ; set; }

        public int spaceCount()
        {
            int count_spaces = 0;

            for(int i = 0; i < this.n; i++)
            {
                if (Line[i] == ' ') 
                { 
                    count_spaces += 1; 
                }

            }

            return count_spaces;
        }

        public void toLower()
        {
            
            for (int i = 0; i < this.n; i++)
            {
                if((int)Line[i] >= 66 && (int)Line[i] <= 90)
                {
                    Line.Insert(i, (char)((int)Line[i] + 32));
                    Line.Remove(i + 1, 1);
                }
            }
        }







    }
}
