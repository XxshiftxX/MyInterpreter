using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterpreter
{
    internal enum TokenType
    {
        Others,
        Digit,
        Letter,
        LeftParen,
        RightParen,
        LeftBracket,
        RightBracket,
        Less,
        Great,
        Plus,
        Minus,
        Multiply,
        Divide,
        Not,
        Mod,
        Assign,
        Comma,
        DoubleQuoto
    }
}
