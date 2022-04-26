using System.Text;

System.Console.WriteLine(ConvertToMilitaryTime("07:05:45PM"));
System.Console.WriteLine(ConvertToMilitaryTime("07:05:45AM"));
System.Console.WriteLine(ConvertToMilitaryTime("12:00:00AM"));
System.Console.WriteLine(ConvertToMilitaryTime("12:00:00PM"));
System.Console.WriteLine(ConvertToMilitaryTime("11:59:59PM"));



static string ConvertToMilitaryTime(string traditionalTime)
{
    var strB = new StringBuilder(traditionalTime);
    _ = strB.Remove(8, 2);
    int intHour = int.Parse(traditionalTime[..2]);

    if (traditionalTime.Substring(8, 2) == "PM")
    {
        if (intHour != 12)
            intHour += 12;
        _ = strB.Remove(0, 2);
        _ = strB.Insert(0, intHour);
        return strB.ToString();
    }
    else
    {
        if (intHour == 12)
        {
            _ = strB.Remove(0, 2);
            _ = strB.Insert(0, "00");
        }

        return strB.ToString();
    }

}