using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test
{
    public class Log
    {
        public List<LogRow> Rows { private set; get; }

        public Log(int logFileSize, string[] logLines)
        {
            Rows = new List<LogRow>();
            if (logLines.Length < logFileSize)
                logFileSize = logLines.Length;
            List<LogRow> rows = new List<LogRow>();
            for (int i = 0; i < logFileSize; i++)
            {
                Rows.Add(new LogRow(logLines[i]));
            }
        }

        public List<string> GetCorrectOrder()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < Rows.Count; i++)
            {
                var row = FindNotUsedLogRowWithMinDigits();
                if (row != null)
                {
                    result.Add(row.LogString);
                }
            }
            return result;
        }

        public LogRow FindNotUsedLogRowWithMinDigits()
        {
            int min = Int32.MaxValue;
            LogRow toReturn = null;
            foreach (var row in Rows)
            {
                if (min > row.DigitsCount && !row.Used)
                {
                    toReturn = row;
                    min = row.DigitsCount;
                }
            }
            if (toReturn != null)
                toReturn.Used = true;
            return toReturn;
        }
    }
    public class LogRow
    {
        public string LogString { private set; get; }
        public List<string> Words { private set; get; }
        public int DigitsCount { private set; get; }
        public bool Used { set; get; }
        public LogRow(string s)
        {
            LogString = s;
            //Words = s.Split(' ');
            CalculateDigitsCount();
        }

        private void CalculateDigitsCount()
        {
            foreach (var word in Words)
            {
                if (double.TryParse(word, out var d))
                {
                    DigitsCount += 1;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = new int[] { 5, 4, 0, 3, 1 ,6, 2};
            int max = 0;
            for(int i=0;i<sequence.Length;i++)
            {
                int tmpMax = 0;
                if(sequence[i] != Int32.MaxValue)
                {
                    int pointer = i;
                    while(sequence[pointer] !=Int32.MaxValue)
                    {
                        tmpMax++;
                        int t = pointer;
                        pointer = sequence[pointer];
                        sequence[t] = Int32.MaxValue;
                    }
                }
                max = Math.Max(max, tmpMax);
            }
		}

		

		public static string GetMaxMentionsCompetitor(Dictionary<string, int> dict)
		{
			int max = 0;
			string returnValue = null;
			foreach (var kv in dict)
			{
				if (kv.Value > max)
				{
					returnValue = kv.Key;
					max = kv.Value;
				}
			}
			return returnValue;
		}
	}
}
