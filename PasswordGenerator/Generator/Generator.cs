using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
    public class Generator
    {
        private const string RangeBase2 = "01";
        private const string RangeBase8 = "01234567";
        private const string RangeBase10 = "0123456789";
        private const string RangeBase16 = "0123456789ABCDEF";
        private const string RangeBase64 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
        private const string RangeLatin = "abcdefghijklmnopqrstuvwxyz";
        private const string RangeCyrillic = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private const string RangePunctuation = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

        private const string PasswordSeparator = " ";

        public string CurrentRange { get { return (currentRangeBuilder ?? CreateRange ()).ToString (); } }

        private StringBuilder currentRangeBuilder;
        private SymbolAlphabetType symbolAlphabetType;
        private SymbolRegisterType symbolRegisterType;
        private DigitalBaseType digitalBaseType;
        private bool isPunctuationInclude;

        public string Generate (int number, int length)
        {
            if (string.IsNullOrEmpty (CurrentRange))
                return string.Empty;

            var array = CurrentRange.ToCharArray ();
            var result = new StringBuilder (number * (length + 1));
            var random = new Random ();

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < length; j++)
                    result.Append (array[random.Next () % array.Length]);

                result.Append (PasswordSeparator);
            }

            return result.ToString ();
        }

        public void SetDigitalRange (DigitalBaseType digitalBase)
        {
            currentRangeBuilder = null;
            digitalBaseType = digitalBase;
        }

        public void SetSymbolsRange (SymbolAlphabetType symbolAlphabet, SymbolRegisterType symbolRegister)
        {
            currentRangeBuilder = null;
            symbolAlphabetType = symbolAlphabet;
            symbolRegisterType = symbolRegister;
        }

        public void SetPunctuationSymbols (bool isPunctuation)
        {
            currentRangeBuilder = null;
            isPunctuationInclude = isPunctuation;
        }

        private StringBuilder CreateRange ()
        {
            currentRangeBuilder = new StringBuilder ();

            switch (digitalBaseType)
            {
                case DigitalBaseType.Base2: currentRangeBuilder.Append (RangeBase2); break;
                case DigitalBaseType.Base8: currentRangeBuilder.Append (RangeBase8); break;
                case DigitalBaseType.Base10: currentRangeBuilder.Append (RangeBase10); break;
                case DigitalBaseType.Base16: currentRangeBuilder.Append (RangeBase16); break;
                case DigitalBaseType.Base64: currentRangeBuilder.Append (RangeBase64); break;
            }

            if ((symbolAlphabetType & SymbolAlphabetType.Latin) > 0)
            {
                if ((symbolRegisterType & SymbolRegisterType.Lowers) > 0)
                    currentRangeBuilder.Append (RangeLatin);

                if ((symbolRegisterType & SymbolRegisterType.Uppers) > 0)
                    currentRangeBuilder.Append (RangeLatin.ToUpper ());
            }

            if ((symbolAlphabetType & SymbolAlphabetType.Cyrillic) > 0)
            {
                if ((symbolRegisterType & SymbolRegisterType.Lowers) > 0)
                    currentRangeBuilder.Append (RangeCyrillic);

                if ((symbolRegisterType & SymbolRegisterType.Uppers) > 0)
                    currentRangeBuilder.Append (RangeCyrillic.ToUpper ());
            }

            if (isPunctuationInclude)
                currentRangeBuilder.Append (RangePunctuation);

            return currentRangeBuilder;
        }
    }
}