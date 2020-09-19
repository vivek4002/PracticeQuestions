using System.Collections.Generic;
using System.Text;
public class LargeMultiplier {
    public string multiply (string s1, string s2) {
        var list = new List<string> ();
        var zerosToAdd = 0;
        foreach (var c in s2.Reverse ()) {
            var carry = 0;
            var sb = new StringBuilder ();
            //append zeros
            for (int i = 0; i < zerosToAdd; i++) {
                sb.Append ("0");
            }
            foreach (var s in s1.Reverse()) {
                var val = ((int) char.GetNumericValue (s) * (int) char.GetNumericValue (c)) + carry;
                carry = val / 10;
                sb.Append (val % 10);
            }
            //reverse string, append carry, and add in list
            if (carry > 0) {
                sb.Append (carry);
            }
            zerosToAdd++;
            var str = sb.ToString ();
            list.Add (str);
        }

        return AddNumbers (list.ToArray ());
    }

    private string AddNumbers (string[] list) {
        var sb = new StringBuilder ();
        var biggestLength = list[list.Length - 1].Length;
        var carry = 0;
        for (int i = 0; i < biggestLength; i++) {
            var sum = 0;
            foreach (var str in list) {
                if (str.Length > i) {
                    sum += ((int) char.GetNumericValue (str[i]));
                }
            }
            sum += carry;
            sb.Append (sum % 10);
            carry = sum / 10;
        }
        if (carry > 0) {
            sb.Append (carry);
        }
        return sb.ToString ().Reverse ();

    }

}