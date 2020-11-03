using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IMyInterface myInterface = new MyImplementation();
            var wordCounts1 = myInterface.GetWordCounts(new[] {"one", "two", "two", "three", "three", "three", "four" });
            // Expected output:
            // wordCounts1 should be { {"one", 1}, {"two", 2}, {"three", 3"}, {"four", 1} }

            var wordCounts2 = myInterface.GetWordCounts("one,two, two, three, three, three, three,Four,four");
            // Expected output:
            // wordCounts2 should be { {"one", 1}, {"two", 2}, {"three", 4"}, {"Four", 1}, {"four", 1} }

            var bit0 = myInterface.IsBitSet(9, 0);
            // Expected output:
            // bit0 should be true, since bit-0 of integer 9 is set

            var bit1 = myInterface.IsBitSet(9, 1);
            // Expected output:
            // bit1 should be false, since bit-1 of integer 9 is not set

            var bit2 = myInterface.IsBitSet(9, 2);
            // Expected output:
            // bit2 should be false, since bit-2 of integer 9 is not set

            var bit3 = myInterface.IsBitSet(9, 3);
            // Expected output:
            // bit3 should be true, since bit-3 of integer 9 is set

            var bitsSet = myInterface.GetBitsSet(9);
            // Expected output:
            // bitsSet should be {0, 3}, since bit-0 and bit-3 of integer 9 are set

            var newValue = myInterface.SetBits(9, new[] { 2 });
            // Expected output:
            // newValue should be 13, since bit-2 of integer 9 are now set

            var newBitsSet = myInterface.GetBitsSet(newValue);
            // Expected output:
            // newBitsSet should be {0, 2, 3}, since bit-0, bit-1 and bit-3 of integer 13 are set
        }
    }
}
