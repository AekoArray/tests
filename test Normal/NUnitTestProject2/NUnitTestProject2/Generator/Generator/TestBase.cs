using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

public class TestBase
{

    private static Random random = new Random();
    internal static string GenerateRandomString(int len)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, len)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}
