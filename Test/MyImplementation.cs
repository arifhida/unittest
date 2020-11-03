using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    public class MyImplementation : IMyInterface
    {
        public IEnumerable<int> GetBitsSet(int value)
        {
            var binary = Convert.ToString(value, 2).Reverse().ToArray();
            List<int> result = new List<int>();
            for (int i = 0; i < binary.Count(); i++)
            {
                if (Convert.ToBoolean(Char.GetNumericValue(binary[i])))
                {
                    result.Add(i);
                }
            }
            return result.ToArray();
        }

        public IEnumerable<Tuple<string, int>> GetWordCounts(string[] words)
        {
            var counted = words.GroupBy(x => x.Trim())
                .Select(g => new
                {
                    g.Key,
                    count = g.Where(x => x.Trim() == g.Key).Count()
                });
            var result = new List<Tuple<string, int>>();
            foreach (var item in counted)
            {
                result.Add(new Tuple<string, int>(item.Key, item.count));
            }
            return result;
        }

        public IEnumerable<Tuple<string, int>> GetWordCounts(string commaDelimitedWords)
        {
            var words = commaDelimitedWords.Split(',');
            return GetWordCounts(words);
        }

        public bool IsBitSet(int value, int bit)
        {
            var binary = Convert.ToString(value, 2).Reverse().ToArray();
            if (bit >= binary.Length)
                return false;
            
            return Convert.ToBoolean(Char.GetNumericValue(binary[bit]));
        }

        public int SetBits(int value, int[] bitsToSet)
        {
            var binary = Convert.ToString(value, 2).Reverse().ToArray();
            var length = (bitsToSet.Max() + 1 > binary.Length) ? bitsToSet.Max() + 1 : binary.Length;

            BitArray arr = new BitArray(length);
            for (int i = 0; i < length; i++)
            {
                if (i < binary.Length)
                {
                    arr[i] = Convert.ToBoolean(Char.GetNumericValue(binary[i]));
                }
                else
                {
                    arr[i] = false;
                }
            }
            
            foreach (var item in bitsToSet)
            {
                arr.Set(item, true);
            }
            int[] array = new int[1];
            arr.CopyTo(array, 0);
            return array[0];
        }
    }
}
