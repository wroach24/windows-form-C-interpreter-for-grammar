using System;
using System.Linq;
using System.Collections.Generic;
namespace WinFormsApp1
{
	public class TokenType
	{
		enum TType //token type enum w/ assigned values for simpler assignment/comparison statements
		{
			IDENTIFIER = 1, ADD = 2, SUB = 3, DIV = 4, GREATER = 5, LESSER = 6, EQUALS = 7, MUL = 8, ASSIGN = 9,
			EOS = 10, KEYWORDS = 11, NUL = 12, CONST = 13, LIST = 14, END = 15, LOOP = 16, PRINT = 17, REPEAT = 18, IF = 19,
			L_PAR = 20, R_PAR = 21, END_L = 22, TO = 23
		}
		enum SType //statement types
		{
			IF_STMT = 1, ASSIGN_STMT = 2, FOR_STMT = 3, GOTO_STMT = 4, PRINT_STMT = 5, END_STMT = 6, nulll = 7, ARITH_STMT = 8
		}

		string lex; //individual lexeme from lexical analyzer
		int line; // corresponding line to lexeme
		TType type; // corresponding tokentype to the lexeme, if lexeme is valid token.
		List<string> keywords = { "dim", "end", "for", "goto", "if", "let", "next", "print", "stop", "rem", "endl", "to" }; // list of current keywords
		
		Linked
		
		vector<char> idents = { 'a','b','c','d','e','f','g','h','i',
							'j','k','l','m','n','o','p','q','r',
							's','t','u','v','w','x','y','z' };
		public TokenType()//base constructor call
		{
			lex = "NUL";
			type = TType.NUL;
			line = 100000;
		}
		public TokenType(string lex, int line)
		{
			this.lex = lex;
			this.line = line;
			type = GetTokenType(lex, line);
		}
		protected TType GetTokenType(string lex, int line)
		{
			try
			{
				bool isNumeric = int.TryParse(lex, out _);
				bool isString = lex.All(char.IsLetter);
				if (isNumeric) //if a number return its type as constant
				{
					type = TType.CONST;
					return type;
				}
				else

			}

		}
	}
}

