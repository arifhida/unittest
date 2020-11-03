using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Test.Tests
{
    public class MyInterfaceTest
    {
        [Theory]
        [InlineData(9,0, true)]
        [InlineData(9, 1, false)]
        [InlineData(9, 2, false)]
        [InlineData(9, 4, false)]
        public void isSetBitTest(int value, int index, bool result)
        {
            IMyInterface myInterface = new MyImplementation();
            var bitset = myInterface.IsBitSet(value, index);
            Assert.Equal<bool>(result, bitset);
        }

        [Theory]
        [InlineData(9, new[] { 2 }, 13)]
        [InlineData(9, new[] { 4 }, 25)]
        public void SetBitTest(int value, int[] idx, int result)
        {
            IMyInterface myInterface = new MyImplementation();
            var newValue = myInterface.SetBits(value, idx);
            Assert.Equal(result, newValue);
        }

        [Theory]
        [InlineData(9, new[] {0, 3})]
        [InlineData(13, new[] { 0,2,3})]
        public void GetBitsTest(int value, int[] result)
        {
            IMyInterface myInterface = new MyImplementation();
            var bitsets = myInterface.GetBitsSet(value);
            Assert.Equal(result, bitsets);
        }

        [Theory]
        [InlineData(new[] { "one", "two", "two", "three", "three", "three", "four" }, new[] { 1,2,3,1})]
        [InlineData(new[] { "one", "two", "two", "three", "three", "three","three", "four" }, new[] { 1, 2, 4, 1 })]
        public void GetWordCountArrayTest(string[] words, int[] result)
        {
            IMyInterface myInterface = new MyImplementation();
            var counted = myInterface.GetWordCounts(words);
            var res = new int[counted.Count()];
            for (int i = 0; i < counted.Count(); i++)
            {
                res[i] = counted.ElementAt(i).Item2;
            }

            Assert.Equal(result, res);
        }

        [Theory]
        [InlineData("one,two, two, three, three, three, three,Four,four", new[] { 1,2,4,1 ,1})]
        [InlineData("one,two, two, three, three, three, three,Four,four,four", new[] { 1, 2, 4, 1, 2 })]
        public void GetWordCountTest(string commadelimiter, int[] result)
        {
            IMyInterface myInterface = new MyImplementation();
            var words = myInterface.GetWordCounts(commadelimiter);
            var res = new int[words.Count()];
            for (int i = 0; i < words.Count(); i++)
            {
                res[i] = words.ElementAt(i).Item2;
            }
            
            Assert.Equal(result, res);
        }
    }
}
