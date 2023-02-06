namespace ReverseTheCase.Tests;

public class StringExtensionTest
{
    [Theory]
    [InlineData("Happy Birthday", "hAPPY bIRTHDAY")]
    [InlineData("MANY THANKS", "many thanks")]
    [InlineData("sPoNtAnEoUs", "SpOnTaNeOuS")]
    public void TestReverseTheCaseSuccess(string str, string resultExpected)
    {
        var result = str.CaseReverse();
        Assert.Equal(resultExpected, result);   
    }
}