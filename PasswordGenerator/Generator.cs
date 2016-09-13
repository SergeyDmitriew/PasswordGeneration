using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
    internal class Generator
    {
        public const string RangeBase2  = "01";
        public const string RangeBase8  = "01234567";
        public const string RangeBase10 = "0123456789";
        public const string RangeBase16 = "0123456789ABCDEF";
        public const string RangeBase64 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";        
    }
}