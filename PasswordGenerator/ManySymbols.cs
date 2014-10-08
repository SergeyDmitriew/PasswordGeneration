using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
    public class ManySymbols
    {
        public const string Latin = "qwertyuiopasdfghjklzxcvbnm";
        public const string Cyrillic = "йцукенгшщзхъфывапролджэячсмитьбюё";
        public const string Numbers = "0123456789";
        public const string Punctuation = @",.?!(){}[]+-*/$#@~`'_%^:;";

        public char[] lettersLatin;
        public char[] lettersCyrillic;
        public char[] lettersNumbers;
        public char[] lettersPunctuation;

        public char[] result;

        public ManySymbols ()
        {
            lettersLatin = Latin.ToCharArray ();
            lettersCyrillic = Cyrillic.ToCharArray ();
            lettersNumbers = Numbers.ToCharArray ();
            lettersPunctuation = Punctuation.ToCharArray ();
        }

        public char[] AddSymbols ()
        {

            return result;
        }
    }
}
