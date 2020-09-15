using System;
using System.Collections.Generic;

public class HappyNumber {
    public bool IsHappyRecursive (int n) {
        return IsHappyRecursive (n, new HashSet<int> ());
    }

    private bool IsHappyRecursive (int n, HashSet<int> set) {
        if (n == 1) return true;
        if (set.Contains (n)) return false;
        set.Add (n);
        return IsHappyRecursive (GetSquaredSumOfDigits (n), set);
    }

    //in iterative method we use floyed's cycle to check if numbers are getting repeated
    // if repeated number is 1 then its a happy number otherwise not.
    // this approach saves lots of space and complexity of recursion.
    public bool IsHappyIterative (int n) {
        int sp = n; //slow pointer
        int fp = n; // fast pointer 
        do {
            sp = GetSquaredSumOfDigits (sp);
            fp = GetSquaredSumOfDigits (GetSquaredSumOfDigits (fp));
        } while (sp != fp);
        if (sp == 1) return true;
        return false;
    }

    //Another approach is based upon observation that any number which is not happy
    // the number 4 occurs in the cycle. so we can use this information to find happy number without
    //using ext memory
    public bool IsHappyWithNoExtraSpace (int n) {
        while (n != 1 && n != 4) {
            n = GetSquaredSumOfDigits (n);
        }
        if (n == 1) return true;
        return false;
    }

    private int GetSquaredSumOfDigits (int n) {
        var sum = 0;
        while (n != 0) {
            sum += (n % 10) * (n % 10);
            n = n / 10;
        }
        return sum;
    }
}