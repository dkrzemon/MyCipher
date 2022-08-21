using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCipher.Service
{
    internal class AllChars
    {
        public List<string> alphabet { get; set; }
        public List<string> consonants { get; set; }
        public List<string> vowels { get; set; }
        public List<string> numbers { get; set; }
        public List<string> specialChars { get; set; }

        public AllChars()
        {
            alphabet = new();
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
            alphabet.Add("z"); //23 elements, 0-22

            consonants = new();
            consonants.Add("b"); //1
            consonants.Add("c"); //2
            consonants.Add("d"); //3
            consonants.Add("f"); //4
            consonants.Add("g"); //5
            consonants.Add("h"); //6
            consonants.Add("j"); //7
            consonants.Add("k"); //8
            consonants.Add("l"); //9
            consonants.Add("m"); //10
            consonants.Add("n"); //11
            consonants.Add("p"); //12
            consonants.Add("r"); //13
            consonants.Add("s"); //14
            consonants.Add("t"); //15
            consonants.Add("w"); //16
            consonants.Add("z"); //17 elements, 0-16

            vowels = new();
            vowels.Add("a"); //1
            vowels.Add("e"); //2
            vowels.Add("i"); //3
            vowels.Add("o"); //4
            vowels.Add("u"); //5
            vowels.Add("y"); //6 elements, 0-5

            numbers = new();
            numbers.Add("0"); //
            numbers.Add("1"); //
            numbers.Add("2"); //
            numbers.Add("3"); //
            numbers.Add("4"); //
            numbers.Add("5"); //
            numbers.Add("6"); //
            numbers.Add("7"); //
            numbers.Add("8"); //
            numbers.Add("9"); //10 elements, 0-9

            specialChars = new();
            specialChars.Add("`"); //
            specialChars.Add("~"); //
            specialChars.Add("!"); //
            specialChars.Add("@"); //
            specialChars.Add("#"); //
            specialChars.Add("$"); //
            specialChars.Add("%"); //
            specialChars.Add("^"); //
            specialChars.Add("&"); //
            specialChars.Add("*"); //
            specialChars.Add("("); //
            specialChars.Add(")"); //
            specialChars.Add("-"); //
            specialChars.Add("_"); //
            specialChars.Add("="); //
            specialChars.Add("+"); //
            specialChars.Add("["); //
            specialChars.Add("{"); //
            specialChars.Add("]"); //
            specialChars.Add("}"); //
            specialChars.Add("\u005c"); // this -> /
            specialChars.Add("|"); //
            specialChars.Add(";"); //
            specialChars.Add(":"); //
            specialChars.Add("'"); //
            specialChars.Add("\u02ba"); //this -> "
            specialChars.Add(","); //
            specialChars.Add("<"); //
            specialChars.Add("."); //
            specialChars.Add(">"); //
            specialChars.Add("/"); //
            specialChars.Add("?"); //32 elements, 0-31
        }
    }
}
