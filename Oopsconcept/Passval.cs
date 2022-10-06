using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Passval
    {
        static bool Validpass(string pass)
        {
            int valcon = 0;
            foreach(char c in pass)
            {
                if (c >= 'a' && c <= 'z')
                {
                    valcon++;
                    break;
                }
            }
            foreach (char c in pass)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    valcon++;
                    break;
                }
            }
            if (valcon == 0)
            {
                return false;
            }
            foreach(char c in pass)
            {
                if (c >= '0' && c <= '9')
                {
                    valcon++;
                    break;
                }
            }
            if (valcon == 1)
            {
                return false;
            }
            if (valcon == 2)
            {
                char[] special = { '@', '#', '$', '%', '&', '*', '+' };
                if (pass.IndexOfAny(special) == -1) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("**note that password must constains charcter symbols and number :**");
            Console.WriteLine("How many password do you want to set : ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("enter password");
            string[] pass = new string[size];
            for(int i = 0; i < pass.Length; i++)
            {
                pass[i] = Console.ReadLine();
            }
            
            foreach(string pasword in pass)
            {
                bool b = Validpass(pasword);
                Console.WriteLine(pasword+ " " +" is{1}  valid password ", pass,b?"":" not valid password try another ");
                
                
            }
            
            
            
        }
        
    }
}
