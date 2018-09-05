using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterpreter
{
    internal class MyInterpreter
    {
        private Dictionary<char, TokenType> TokenTypes = new Dictionary<char, TokenType>();
        private static void Main(string[] args)
        {

        }

        private void InitializeTokenTypes()
        {
            for (var i = 0; i < 256; i++)
                TokenTypes.Add((char)i, TokenType.Others);
            for (var i = '0'; i <= '9'; i++)
                TokenTypes.Add(i, TokenType.Digit);
            for (var i = 'A'; i <= 'z'; i++)
                TokenTypes.Add(i, TokenType.Letter);

            TokenTypes.Add('_', TokenType.Letter);
            TokenTypes.Add('(', TokenType.LeftParen);
            TokenTypes.Add(')', TokenType.RightParen);
            TokenTypes.Add('[', TokenType.LeftBracket);
            TokenTypes.Add(']', TokenType.RightBracket);
            TokenTypes.Add('+', TokenType.Plus);
            TokenTypes.Add('-', TokenType.Minus);
            TokenTypes.Add('*', TokenType.Multiply);
            TokenTypes.Add('/', TokenType.Divide);
            TokenTypes.Add('%', TokenType.Mod);
            TokenTypes.Add('<', TokenType.Great);
            TokenTypes.Add('>', TokenType.Less);
            TokenTypes.Add('!', TokenType.Not);
            TokenTypes.Add('=', TokenType.Assign);
            TokenTypes.Add(',', TokenType.Comma);
            TokenTypes.Add('\"', TokenType.DoubleQuoto);
        }
    }
}
