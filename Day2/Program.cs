using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            int correctPasswords = 0;
            char[] separators = {' ', '-', ':'};
            string[] passwordsArray = System.IO.File.ReadAllLines("Day2.txt");
            foreach(var line in passwordsArray )
            {
                string[] passParameters = line.Split(separators, StringSplitOptions.RemoveEmptyEntries); 
                if(CheckingCorretness2(Int32.Parse(passParameters[0])-1,Int32.Parse(passParameters[1])-1,
                                      Convert.ToChar(passParameters[2]), passParameters[3]))
                                      {
                                        correctPasswords++;
                                      }
            }
            Console.WriteLine(correctPasswords);
        }
        static public bool CheckingCorretness(int min, int max, char key, string password)
        {
            int ammount = 0;
            foreach(var letter in password)
            {
                if(letter == key) ammount++;
                if(ammount>max) return false;
            }
            if(ammount<min) return false;
            return true;
        }
        static public bool CheckingCorretness2(int min, int max, char key, string password)
        {
            if(max > password.Length) return false;
            if((password[min] == key && password[max] != key) || (password[min] != key && password[max] == key)) return true;
            return false;
        }
    }
}
