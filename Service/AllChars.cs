using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCipher.Service
{
    internal class AllChars
    {
        public AllChars()
        {
            List<string> alphabet = new List<string>();
            alphabet.Add("a");
            alphabet.Add("b");
            alphabet.Add("c");
            alphabet.Add("d");
            alphabet.Add("e");
            alphabet.Add("f");
            alphabet.Add("g");
            alphabet.Add("h");
            alphabet.Add("i");
            alphabet.Add("j");
            alphabet.Add("k");
            alphabet.Add("l");
            alphabet.Add("m");
            alphabet.Add("n");
            alphabet.Add("o");
            alphabet.Add("p");
            alphabet.Add("r");
            alphabet.Add("s");
            alphabet.Add("t");
            alphabet.Add("w");
            alphabet.Add("x");
            alphabet.Add("y");
            alphabet.Add("z");

            List<string> consonants = new List<string>();
            consonants.Add("b");
            consonants.Add("c");
            consonants.Add("d");
            consonants.Add("f");
            consonants.Add("g");
            consonants.Add("h");
            consonants.Add("j");
            consonants.Add("k");
            consonants.Add("l");
            consonants.Add("m");
            consonants.Add("n");
            consonants.Add("p");
            consonants.Add("r");
            consonants.Add("s");
            consonants.Add("t");
            consonants.Add("w");
            consonants.Add("z");

            List<string> vowels = new List<string>();
            vowels.Add("a");
            vowels.Add("e");
            vowels.Add("i");
            vowels.Add("o");
            vowels.Add("u");
            vowels.Add("y");

            List<string> specialChars = new List<string>();
            specialChars.Add("`");
            specialChars.Add("~");
            specialChars.Add("!");
            specialChars.Add("@");
            specialChars.Add("#");
            specialChars.Add("$");
            specialChars.Add("%");
            specialChars.Add("^");
            specialChars.Add("&");
            specialChars.Add("*");
            specialChars.Add("(");
            specialChars.Add(")");
            specialChars.Add("-");
            specialChars.Add("_");
            specialChars.Add("=");
            specialChars.Add("+");
            specialChars.Add("[");
            specialChars.Add("{");
            specialChars.Add("]");
            specialChars.Add("}");
            specialChars.Add("\u005c"); // this -> /
            specialChars.Add("|");
            specialChars.Add(";");
            specialChars.Add(":");
            specialChars.Add("'");
            specialChars.Add("\u02ba"); //this -> "
            specialChars.Add(",");
            specialChars.Add("<");
            specialChars.Add(".");
            specialChars.Add(">");
            specialChars.Add("/");
            specialChars.Add("?");
        }
    }
}
