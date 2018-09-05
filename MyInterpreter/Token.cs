using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterpreter
{
    internal class Token
    {
        internal TokenType Type { get; }
        internal string Text { get; }
        internal double DoubleValue { get; }

        public Token(double doubleValue, string text, TokenType type)
        {
            DoubleValue = doubleValue;
            Text = text;
            Type = type;
        }
    }
}
