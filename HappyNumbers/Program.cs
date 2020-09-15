using System;

namespace HappyNumbers {
    class Program {
        //Happy numbers are the numbers when you recursively add the square of the digits, it ends to 1.
        // eg: 7 -> 49 -> 97 -> 130 -> 10 ->1 So 7 is happy number 
        // similarly 4 is not happy number
        static void Main (string[] args) {
            HappyNumber checkHappy = new HappyNumber ();
            //Recursive
            Console.WriteLine ($"Is 7 happy: {checkHappy.IsHappyRecursive(7)}");
            Console.WriteLine ($"Is 4 happy: {checkHappy.IsHappyRecursive(4)}");
            Console.WriteLine ($"Is 9 happy: {checkHappy.IsHappyRecursive(9)}");
            Console.WriteLine ($"Is 13 happy: {checkHappy.IsHappyRecursive(13)}");
            //Iterative
            Console.WriteLine ($"Is 9 happy: {checkHappy.IsHappyIterative(9)}");
            Console.WriteLine ($"Is 10 happy: {checkHappy.IsHappyIterative(10)}");
            Console.WriteLine ($"Is 13 happy: {checkHappy.IsHappyIterative(13)}");
            Console.WriteLine ($"Is 19 happy: {checkHappy.IsHappyIterative(19)}");
            //No extra space
            Console.WriteLine ($"Is 7 happy: {checkHappy.IsHappyWithNoExtraSpace(7)}");
            Console.WriteLine ($"Is 9 happy: {checkHappy.IsHappyWithNoExtraSpace(9)}");
            Console.WriteLine ($"Is 13 happy: {checkHappy.IsHappyWithNoExtraSpace(13)}");
            Console.WriteLine ($"Is 17 happy: {checkHappy.IsHappyWithNoExtraSpace(17)}");
        }
    }
}