using System;
using System.Collections.Generic;
using System.Linq;

public class HW1Code
{
    public static int AddTwo(int a, int b) {
        return a + b;
    }

    public static int TwoMax(int a, int b) {
        if(a > b) {
            return a;
        } else {
       	    return b;
	}
    }

    public static int ThreeMax(int a, int b, int c) {
        if(a > b) {
	   if(a > c) {
	      return a;
	   }
           return c;
        } else {
           if(b > c) {
	      return b;
           }
	   return c;
	}
    }

    public static bool StartsWithVowel(char input) {
       if(input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u') {
          return true;
       } else {
          return false;
       }
    }

    public static bool PalindromeCheck(String s){
        char[] a = s.ToCharArray();
	Array.Reverse(a);
	char[] b = s.ToCharArray();
	bool flag = true;
        for(int i = 0; i < a.Length; i++) {
	   if(a[i] != b[i]) {
	      flag = false;
	   }
        }
	return flag;
    }

    public static int[] OddArray(int[] arr) {
        int[] newArr = new int[arr.Length];
	int c = 0;
	for(int i = 0; i < arr.Length; i++) {
	    if(!(arr[i] % 2 == 0)) {
	        newArr[c] = arr[i];
		c++;
	    }
	}
	int[] newNewArr = new int[c];
	for(int i = 0; i < newNewArr.Length; i++) {
	    newNewArr[i] = newArr[i];
	}
	return newNewArr;
    }

    public static int Multiply(int[] list) {
        int p = 1;
        foreach(int i in list) {
	    p = p*i;
    	}
	return p;
    }

    public static bool IsSorted(int[] list) {
        bool result = true;
	int last = int.MinValue;
	foreach(int i in list) {
	    if(i < last) {
	        result = false;
	    }
	    last = i;
	}
	return result;
    }

    public static int Lowest(int[] arr) {
        int low = int.MaxValue;
	foreach(int i in arr) {
	    if(i < low){
	        low = i;
	    }
	}
	return low;
    }

    public static int Dups(char[] arr) {
        int c = 0;
	for(int i = 0; i < arr.Length; i++) {
	    for(int j = i; j <arr.Length-1; j++) {
	        if(arr[i] == arr[j+1]) {
		    c++;
		}
	    }
	}
	return c;
    }

    public static String LowestValue(Dictionary<int,string> d) {
        int low = int.MaxValue;
	foreach(KeyValuePair<int,string> entry in d) {
	    if(entry.Key < low) {
	        low = entry.Key;
	    }
	}
	return d[low];
    }

    public static bool PangramCheck(String s) {
        bool b = true;
	char[] alphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
	foreach(char e in alphabet) {
	    if(!(s.ToLower().Contains(e))) {
	        b = false;
	    }
	}
	return b;
    }

    //True if 3 by 3, numbers 1 - 9 occur exactly once, and sum of row/col/diag add up to same number
    public static bool LoShu(int[][] arr) {
        if(arr.Length != 3) {
	    return false;
	}
	if(arr[0].Length != 3) {
	    return false;
	}
	int totalTarg = arr[0][0] + arr[1][0] +arr[2][0];

        if(arr[0][2] + arr[1][2] + arr[2][2] != totalTarg
	    || arr[0][0] + arr[0][1] + arr[0][2] != totalTarg
	    || arr[1][0] + arr[1][1] + arr[1][2] != totalTarg
	    || arr[2][0] + arr[2][1] + arr[2][2] != totalTarg
	    || arr[0][0] + arr[1][1] + arr[1][1] != totalTarg
	    || arr[0][2] + arr[1][1] + arr[2][0] != totalTarg) {
	        return true;
	    }
	return true;
    }

    public static List<string> FilterLongWords(List<string> s, int n) {
        List<string> final = new List<string>();
	foreach(string word in s) {
	    if(word.Length > n) {
	        final.Add(word);
	    }
	}
	final = final.ConvertAll(word => word.ToUpper());
	return final;
    }
    
    public static void Main() {
       Console.WriteLine("Expected:7 Actual:" + AddTwo(3,4));
       Console.WriteLine("Expected:4 Actual:" + TwoMax(3,4));
       Console.WriteLine("Expected:3 Actual:" + ThreeMax(1,2,3));
       Console.Write("Expected:True,False     Actual: ");
       if(StartsWithVowel('a')) {
          Console.Write("True,");
       }
       if(StartsWithVowel('b')) {
          Console.Write("True");
       } else {
          Console.WriteLine("False");
       }
       Console.Write("Expected:False,True     Actual: ");
       if(PalindromeCheck("cat")) {
          Console.Write("True,");
       } else {
          Console.Write("False,");
       }
       if(PalindromeCheck("bob")) {
          Console.WriteLine("True");
       } else {
          Console.WriteLine("False");
       }
       char[] a = {'a', 'b', 'c'};
       Dups(a);
    }
}
