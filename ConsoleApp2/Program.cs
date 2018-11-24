using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "А это это пшеница пшеница! Пшеница в темном чулане хранится.";
            Console.WriteLine(txt);
            string preparedStr = txt.Replace("!", " <!> ").Replace(".", " <.> ");
            string[] words = preparedStr.Split(' ');
            StringBuilder txtbuild = new StringBuilder();
            txtbuild = RemoveRepeats(words);
            txtbuild.Replace(" <!> ", "!").Replace(" <.> ", ".");
            Console.WriteLine(txtbuild);
        }

        static StringBuilder RemoveRepeats(string[] words)
        {
            StringBuilder txtbuild = new StringBuilder();
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i].StartsWith("<") || words[i] != words[i + 1])
                {
                    txtbuild.Append(words[i] + " ");
                }
            }
            txtbuild.Append(words[words.Length - 1]);
            return txtbuild;
        }
    }
}
