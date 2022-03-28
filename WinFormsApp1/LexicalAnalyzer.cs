using System;
using System.Text;
using System.Collections.Generic;

namespace WinFormsApp1
{
	public class LexicalAnalyzer
	{
		LinkedList<string> lexemes;
		string[] lines;
		int lineNum; //linenumber

		public LexicalAnalyzer()
		{

		}
		public LexicalAnalyzer(string path)
		{
			lineNum = 1;
			lines = File.ReadAllLines(path);
			for(int i = 0; i < lines.Count(); i++)
            {
				processLine(lines[i], lineNum);
				lineNum++;
            }

		}

		protected void processLine(string line, int lineNumber)
        {

        }
	}
}

