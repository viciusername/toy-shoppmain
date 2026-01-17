<<<<<<< HEAD

using Xunit;
using ToyPlanet.Core;

public class ToyTests
{
    [Fact]
    public void ToyPrice_ShouldBePositive()
    {
        var toy = new Toy { Price = 100 };
        Assert.True(toy.Price > 0);
    }
}
=======

using Xunit;
using ToyPlanet.Core;

public class ToyTests
{
    [Fact]
    public void ToyPrice_ShouldBePositive()
    {
        var toy = new Toy { Price = 100 };
        Assert.True(toy.Price > 0);
    }
}
>>>>>>> 2521093c90b9ade13d296cf0b5c441d71b5804ae
