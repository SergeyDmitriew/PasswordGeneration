using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
    public class Generator
    {
        public const string RangeBase2 = "01";
        public const string RangeBase8 = "01234567";
        public const string RangeBase10 = "0123456789";
        public const string RangeBase16 = "0123456789ABCDEF";
        public const string RangeBase64 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

        public const string RangeLatin = "abcdefghijklmnopqrstuvwxyz";
        public const string RangeCyrillic = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public const string RangePunctuation = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

        public string CurrentRange { get { return (stringBuilder ?? CreateRange ()).ToString (); } }
        private StringBuilder stringBuilder;
        private SymbolAlphabetType symbolAlphabetType;
        private SymbolRegisterType symbolRegisterType;
        private DigitalBaseType digitalBaseType;
        private bool isPunctuationInclude;

        public void SetDigitalRange (DigitalBaseType digitalBase)
        {
            stringBuilder = null;
            digitalBaseType = digitalBase;
        }

        public void SetSymbolsRange (SymbolAlphabetType symbolAlphabet, SymbolRegisterType symbolRegister)
        {
            stringBuilder = null;
            symbolAlphabetType = symbolAlphabet;
            symbolRegisterType = symbolRegister;
        }

        public void SetPunctuationSymbols (bool isPunctuation)
        {
            stringBuilder = null;
            isPunctuationInclude = isPunctuation;
        }

        private StringBuilder CreateRange ()
        {
            stringBuilder = new StringBuilder ();

            switch (digitalBaseType)
            {
                case DigitalBaseType.Base2: stringBuilder.Append (RangeBase2); break;
                case DigitalBaseType.Base8: stringBuilder.Append (RangeBase8); break;
                case DigitalBaseType.Base10: stringBuilder.Append (RangeBase10); break;
                case DigitalBaseType.Base16: stringBuilder.Append (RangeBase16); break;
                case DigitalBaseType.Base64: stringBuilder.Append (RangeBase64); break;
            }

            if ((symbolAlphabetType & SymbolAlphabetType.Latin) > 0)
            {
                if ((symbolRegisterType & SymbolRegisterType.Lowers) > 0)
                    stringBuilder.Append (RangeLatin);

                if ((symbolRegisterType & SymbolRegisterType.Uppers) > 0)
                    stringBuilder.Append (RangeLatin.ToUpper ());
            }

            if ((symbolAlphabetType & SymbolAlphabetType.Cyrillic) > 0)
            {
                if ((symbolRegisterType & SymbolRegisterType.Lowers) > 0)
                    stringBuilder.Append (RangeCyrillic);

                if ((symbolRegisterType & SymbolRegisterType.Uppers) > 0)
                    stringBuilder.Append (RangeCyrillic.ToUpper ());
            }

            if (isPunctuationInclude)
                stringBuilder.Append (RangePunctuation);

            return stringBuilder;
        }

        public string Generate (int passwordNumber, int passwordLength)
        {
            return string.Empty;
        }
    }
}