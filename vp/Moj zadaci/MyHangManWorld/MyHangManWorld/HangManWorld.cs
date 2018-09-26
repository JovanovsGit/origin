using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHangManWorld
{

    // Celata logika na igrata
    public class HangManWorld
    {
        public int pogresniObidi { get; set; }
        public string Word { get; set; }
        public static int maxObidi = 5;
        public List<char> wordLetters { get; set; } // namaluvam kako sto gi pogoduvam
        public List<char> allLetters { get; set; } // site bukvi / obidi za da se pogodi zborot

        public HangManWorld(string w)
        {
            Word = w;
            allLetters = new List<char>();
            wordLetters = new List<char>();
            foreach(char c in Word)
            {
                wordLetters.Add(Char.ToLower(c));
            }
            pogresniObidi = 0;
        }

        public string MaskWord() // Стринг за приказ на зборот. Секоја не погодена буква се заменува со "_" и се додава празно место помеѓу буквите.
        {
            StringBuilder guess = new StringBuilder();

            for(int i = 0; i < Word.Length; i++)
            {
                char c = Word[i];
                c = Char.ToLower(c);
                if (wordLetters.Contains(c))
                {
                    guess.Append("_");
                }
                else
                {
                    guess.Append(Word[i]);
                }
                if(i != Word.Length - 1)
                {
                    guess.Append(" ");
                }
            }
           
            return guess.ToString();
        }

        public string getAllLetters() // Стринг со сите букви кои се искористени.
        {
            StringBuilder res = new StringBuilder();

            for(int i = 'a'; i <= 'z'; i++)
            {
                if (allLetters.Contains(Convert.ToChar(i)))
                {
                    res.Append(Convert.ToChar(i));
                }
                else
                {
                    res.Append("_");
                }
                res.Append(" ");
            }
            return res.ToString();
        }

        public bool GuessLetter(char letter)
        {
            if (allLetters.Contains(letter))
            {
                return false;
            }
            allLetters.Add(letter);
            if (wordLetters.Contains(letter))
            {
                wordLetters.Remove(letter);
            }
            else
            {
                pogresniObidi++;
            }
            return true;
        }
        
        public bool didWin()
        {

            if(wordLetters.Count == 0)
            {
                return true;      ///////////////////asdasdasdasdasd
            }
            else
            {
                return false;
            }
            
        }
    }

}
