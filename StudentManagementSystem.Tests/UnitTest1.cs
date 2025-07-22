using Xunit;

namespace StudentManagementSystem.Tests;

public class UnitTest1
{
    [Fact]
    public void ToplamaDogruMu()
    {
        int sonuc = 2 + 3;
        Assert.Equal(5, sonuc); // ✅ Bu doğru testtir
    }
}
