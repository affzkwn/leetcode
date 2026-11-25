public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
         var areaCode = phoneNumber.Substring(0, 3);
        var FindisFake = phoneNumber.Substring(4, 3);
        var localNumber = phoneNumber.Substring(8, 4);
        bool isNewYork = areaCode == "212";
        bool isFake = FindisFake == "555";

        return (isNewYork, isFake, localNumber);
        throw new NotImplementedException($"Please implement the (static) PhoneNumber.Analyze() method");
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
        throw new NotImplementedException($"Please implement the (static) PhoneNumber.IsFake() method");
    }
}
