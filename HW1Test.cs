using NUnit.Framework;

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
	}
}
