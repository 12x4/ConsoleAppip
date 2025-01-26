using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data;
using Microsoft.CSharp;
using System.Runtime.Remoting.Messaging;
using System.Runtime.CompilerServices;

namespace new_word_CLass
{
    public class stringTwo
    {
        private StringBuilder Line;
        private int n;

        private string up_symbols = "abcdefghijklmnopqrstuvwxyz".ToUpper();
        private string low_symbols = "abcdefghijklmnopqrstuvwxyz";
        private string punctuation_symbols = ",./&^%$#!?-_";

        public stringTwo(int len)
        {
            this.n = len;

            Line = new StringBuilder(n);
        }

        public string Word
        {
            get
            {
                return Line.ToString();
            }
            set
            {
                Line.Clear();
                Line.Append(value);
            }
        }

        public int Length
        {
            get { return Line.Length; }
        }

        public int spaceCount()
        {
            int count_spaces = 0;

            for (int i = 0; i < this.n; i++)
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

            for (int i = Line.Length - 1; i >= 0; i--)
            {
                if ((int)Line[i] >= 66 && (int)Line[i] <= 90)
                {
                    Line.Insert(i, (char)((int)Line[i] + 32));
                    Line.Remove(i + 1, 1);
                }
            }
        }

        public void deletePunctuation()
        {

            for (int i = this.Line.Length - 1; i >= 0; i--)
            {

                if (punctuation_symbols.Contains(this.Line[i].ToString()))
                {
                    this.Line.Remove(i, 1);
                }
            }
        }

        public char this[int index] 
            {
                get{ return Line[index]; }
            }

        public static stringTwo operator +(stringTwo str)
        {
            string new_str = str.Word.ToUpper();
            str.Word = new_str;

            return str;
        }

        public static stringTwo operator -(stringTwo str)
        {
            string new_str = str.Word.ToLower();
            str.Word = new_str;

            return str;
        }

        public static bool operator true(stringTwo str)
        {
            if (str.Word == "" || str.Word == null || str.Length == 0)
            {
                return false;    
            }

            return true;
        }

        public static bool operator false(stringTwo str)
        {
            if (str.Word == "" || str.Word == null || str.Length == 0)
            {
                return false;
            }

            return true;
        }

        public static bool operator &(stringTwo str, stringTwo str_2)
        {
            if (str.Word.ToUpper() == str_2.Word.ToUpper())
            {
                return true;
            }

            return false;
        }

        public static implicit operator string(stringTwo str)
        {
            return str.Word;
        }

        public static implicit operator stringTwo(string str)
        {
            stringTwo boom = new stringTwo(100);
            boom.Word = str;
            return boom; 
        }

    }

    public class RegexTwo
    {
        private Regex regex;
        private string input_word;

        public bool containsFragments()
        {
            Regex regex_form = this.regex;
            MatchCollection Mtaches = regex_form.Matches(input_word);

            if (Mtaches.Count == 0) 
            {
                
                return false;

            }

            return true;
        }

        public void writeAllContainsForms()
        {
            Regex regex_form = this.regex;
            MatchCollection Matches = regex_form.Matches(input_word);

            foreach ( Match match_elem in Matches)
            {
                Console.WriteLine(match_elem.Value);
            }
        }

        public void delRegForm()
        {
            Regex regex_form = regex;
            input_word = regex_form.Replace(input_word, "");
        }

        public void test()
        {  
            Console.WriteLine("Current text: " + input_word);

        } 

        public string text
        {
            get
            {
                return input_word;
            }

            set
            {
                input_word = value;
            }
        }

        public Regex regexF
        {
            get
            {
                return regex;
            }

            set
            {
                regex = value;
            }

        }

        public static RegexTwo operator -(RegexTwo _r)
        {
            _r.delRegForm();
            return _r;
        }

        public static bool operator true(RegexTwo str)
        {
            if (str.text == "" || str.text == null)
            {
                return false;
            }

            return true;
        }

        public static bool operator false(RegexTwo str)
        {
            if (str.text == "" || str.text == null)
            {
                return false;
            }

            return true;
        }

        public static RegexTwo operator +(RegexTwo _r, string str)
        {
            _r.text += str;
            return _r;
        }

        public static implicit operator RegexTwo(string str)
        {
            RegexTwo _r = new RegexTwo();
            _r.text = str;

            return _r;
        }

        public static implicit operator string(RegexTwo _r)
        {
            return _r.text;
        }

        public object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        {
                            return regex;
                        }
                    case 1:
                        {
                            return input_word;
                        }
                    default: 
                        {
                            throw new Exception("You fool");
                        }
                }
            }

            set
            {
                switch (index)
                {
                    case 0:
                        {
                            regex = (Regex)value;
                            break;
                        }
                    case 1:
                        {
                            input_word = (string)value;
                            break;
                        }
                    default:
                        {
                            throw new Exception("You fool");
                        }
                }
            }


        }
    }

    public class DateTimeTwo
    {

        private DateTime data;

        public DateTimeTwo(DateTime data)
        {
            this.data = data;
        }

        public DateTimeTwo()
        {
            this.data = new DateTime(2025, 1, 1);
        }

        public void dataNext()
        {
            TimeSpan one_day = new TimeSpan(24, 0, 0);

            this.data += one_day;
        }

        public void dataLast()
        {
            TimeSpan one_day = new TimeSpan(24, 0, 0);

            this.data = this.data - one_day;
        }

        public void daysEndTheMonth()
        {
            int current_montch = data.Month;
            int current_year = data.Year;

            current_montch += 1;

            if (current_montch > 12)
            {
                current_montch = 1;
                current_year += 1;
            }

            DateTime new_data = new DateTime(current_year, current_montch, 1);


            TimeSpan difference_date = new_data - this.data;

            Console.WriteLine(difference_date.Days - 1);


        }

        public DateTime Data
        {
            get
            {
                return this.data;
            }

            set
            {
                this.data = value;
            }
        }

        public static bool operator !(DateTimeTwo current_data)
        {
            TimeSpan boom = new TimeSpan(24, 0 , 0);
            DateTime new_data = current_data.Data + boom;
            if (new_data.Day == 1)
            {
                return false;
            }
            return true;
        }

        public static bool operator true(DateTimeTwo current_data)
        {
            if (current_data.Data.Day == 1 && current_data.Data.Month == 1)
            {
                return true;
            }
            return false;
        }

        public static bool operator false(DateTimeTwo current_data)
        {
            if (current_data.Data.Day == 1 && current_data.Data.Month == 1)
            {
                return true;
            }
            return false;
        }

        public static bool operator &(DateTimeTwo data_1, DateTimeTwo data_2)
        {
            if (data_1.Data == data_2.Data)
            {
                return true;
            }

            return false;
        }

        public static implicit operator string(DateTimeTwo current_data)
        {
            return current_data.Data.ToString();
        }

        public static implicit operator DateTimeTwo(string str)
        {
            DateTimeTwo new_data = new DateTimeTwo();

            //string to DateTime
            new_data.Data = DateTime.Parse(str);

            return new_data;
        }

        public DateTime this[int index]
        {
            get
            {
                TimeSpan days = new TimeSpan(24 * Math.Abs(index), 0, 0);

                if (index > 0)
                {
                    return Data + days;
                }
                else
                {
                    return Data - days;
                }
            }
        }
    }   
}
