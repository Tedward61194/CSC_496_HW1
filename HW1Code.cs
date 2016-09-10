
using System;

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
    }
}
