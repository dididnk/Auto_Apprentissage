using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HangHimGame
{
    public class Game
    {
        public string Word { get; set; } = string.Empty;

        public Game(string word = "football")
        {
            this.Word = word.ToUpper();
        }

        private char AskCharacter()
        {
            try
            {
                Console.WriteLine("\nEnter a letter : ");
                string? word = Console.ReadLine();
                if (word == null || word.Trim() == "" || word.Trim().Length > 1)
                {
                    Console.WriteLine("Enter only a character ! ");
                    return this.AskCharacter();
                }
                if (!Regex.IsMatch(word, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine("Enter only letter please !");
                    return this.AskCharacter();
                }
                return word.ToUpper()[0];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Start()
        {
            int characterFound = 0;
            int cpt = 0;
            Console.WriteLine("---------- Game Started ----------");
            Console.WriteLine("Find the word : ");
            for(int i = 0; i < this.Word.Length - 1; i++)
            {
                Console.Write("_ ");
            }

            while (true)
            {
                var word = this.AskCharacter();
                
                
                for (int i = 0; i < this.Word.Length - 1; i++)
                {
                    cpt++;
                    if (this.Word[i] == word)
                    {
                        Console.Write($"{this.Word[i]} ");
                        characterFound++;
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }
                if (characterFound == this.Word.Length - 1)
                {
                    Console.WriteLine($"You won :) by ${cpt} tests");
                    break;
                }
            }
            Console.WriteLine("\n---------- End ----------");
        }
    }
}
