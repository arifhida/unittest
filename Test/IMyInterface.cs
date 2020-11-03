using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public interface IMyInterface
    {
        /// <summary>
        /// Gets the number of count for each unique word (case-sensitive) in the supplied array of words
        /// </summary>
        /// <param name="words">An array of words to be processed</param>
        /// <returns>The list of unique words, each with the respective number of count</returns>
        IEnumerable<Tuple<string, int>> GetWordCounts(string[] words);

        /// <summary>
        /// Gets the number of count for each unique word (case-sensitive) in the supplied comma-delimited 
        /// list of words
        /// </summary>
        /// <param name="commaDelimitedWords">A comma-delimited list of words to be processed</param>
        /// <returns>The list of unique words, each with the respective number of count</returns>
        IEnumerable<Tuple<string, int>> GetWordCounts(string commaDelimitedWords);

        /// <summary>
        /// Checks if the specified bit is set in the given value
        /// </summary>
        /// <param name="value">The value the bit of which is to be checked</param>
        /// <param name="bit">The bit to check</param>
        /// <returns>true if the specified bit is set, otherwise false</returns>
        bool IsBitSet(int value, int bit);

        /// <summary>
        /// Gets the bits that are set in the given value
        /// </summary>
        /// <param name="value">The value the bits of which are to be checked</param>
        /// <returns>The bits that are set in the given value</returns>
        IEnumerable<int> GetBitsSet(int value);

        /// <summary>
        /// Sets the specified bits in the given value
        /// </summary>
        /// <param name="value">The value the bits of which are to be set</param>
        /// <param name="bitsToSet">The bits to set in the given value</param>
        /// <returns>The new value after the specified bits are set</returns>
        int SetBits(int value, int[] bitsToSet);
    }
}
