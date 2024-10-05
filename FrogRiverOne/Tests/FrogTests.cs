using FrogRiverOne;

namespace Tests;

public class FrogTests
{
    [Test]
    public void CalculateJumpTime()
    {
        var jumpSecond = Frog.CalculateJumpTime(5, [1, 3, 1, 4, 2, 3, 5, 4]);

        Assert.AreEqual(6, jumpSecond);
    }
    
    [Test]
    public void CalculateJumpTime_NoSolution()
    {
        var jumpSecond = Frog.CalculateJumpTime(5, [1, 3, 1, 4, 2, 3, 2, 4]);

        Assert.AreEqual(-1, jumpSecond);
    }
}