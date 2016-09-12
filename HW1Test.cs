using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class HW1Test {
/*
	HW1Code code;

	[SetUp]
	public void Init() {
		code = new HW1Code();
	} */

	[Test]
	public void AddTwo_Test() {
		Assert.AreEqual(HW1Code.AddTwo(4,6), 10);
		Assert.AreEqual(HW1Code.AddTwo(1,-5), -4);
		Assert.AreEqual(HW1Code.AddTwo(-100,-99), -199);
	}

	[Test]
	public void TwoMax_Test() {
	       Assert.AreEqual(HW1Code.TwoMax(-1,1), 1);
	       Assert.AreEqual(HW1Code.TwoMax(5,4), 5);
	}
	
	[Test]
	public void ThreeMax_Test() {
		Assert.AreEqual(HW1Code.ThreeMax(1,2,3), 3);
		Assert.AreEqual(HW1Code.ThreeMax(5,4,3), 5);
		Assert.AreEqual(HW1Code.ThreeMax(-2,0,1), 1);
	}

	[Test]
	public void StartsWithVowel_Test() {
	       Assert.IsTrue(HW1Code.StartsWithVowel('a'));
	       Assert.IsFalse(HW1Code.StartsWithVowel('b'));
	}

	[Test]
	public void PalindromeCheck_Test() {
	       Assert.IsTrue(HW1Code.PalindromeCheck("bob"));
	       Assert.IsFalse(HW1Code.PalindromeCheck("red"));
	}
	
	[Test]
	public void OddArray_Test() {
	       Assert.AreEqual(HW1Code.OddArray(new[] {1,2,3,4,5}), (new[] {1,3,5}));
	       Assert.AreEqual(HW1Code.OddArray(new[] {2,4,6}), (new int[] {}));
	}

	[Test]
	public void Multiply_Test() {
	       Assert.AreEqual(HW1Code.Multiply(new[] {2,3,4}), 24);
	}

	[Test]
	public void IsSorted_Test() {
	       Assert.IsTrue(HW1Code.IsSorted(new[] {1,2,3,4,5}));
	       Assert.IsFalse(HW1Code.IsSorted(new[] {5,4,3,2,1}));
	}

	[Test]
	public void Lowest_Test() {
	       Assert.AreEqual(HW1Code.Lowest(new[] {-3, 6, 2, 15}), -3);
	}

	[Test]
	public void Dups_Test() {
	       Assert.AreEqual(HW1Code.Dups(new[] {'a','b','c'}),0);
	       Assert.AreEqual(HW1Code.Dups(new[] {'a','b','a','c'}),1);
	       Assert.AreEqual(HW1Code.Dups(new[] {'a','1','1','b','a'}),2);	       
	}

	[Test]
	public void LowestValue() {
	       Dictionary<int,string> dic1  = new Dictionary<int,string>();
	       dic1.Add(2,"Apple");
	       dic1.Add(4,"Banana");
	       Assert.AreEqual(HW1Code.LowestValue(dic1),"Apple");
	       Dictionary<int,string> dic2 = new Dictionary<int,string>();
	       dic2.Add(5,"Books");
	       dic2.Add(0,"Games");
	       dic2.Add(3,"Cards");
	       Assert.AreEqual(HW1Code.LowestValue(dic2),"Games");
	}
}
