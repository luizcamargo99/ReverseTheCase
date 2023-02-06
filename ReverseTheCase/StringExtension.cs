namespace ReverseTheCase;

public static class StringExtension
{
    public static string CaseReverse(this string str)
    {
        var reversedStr = string.Empty;
        var strArray = str.ToArray();

        for (int i = 0; i < strArray.Length; i++)
        {
            var currentLetter = strArray[i].ToString();
            reversedStr += currentLetter == currentLetter.ToUpper() ? currentLetter.ToLower() : currentLetter.ToUpper();
        }

        return reversedStr;
    }
}