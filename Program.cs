Console.WriteLine("INPUT THE THREE DIGIT NUMBER IN FORMAT (HTU)");
try
{
    var input = Console.ReadLine();
    var chars = input.ToCharArray();
    var output = " ";
    var cyclecount = 0;
    for (int i = chars.Length - 1; i >= 0; i--)
    {
        if (cyclecount == 0)
        {
            //unit
            switch (int.Parse(chars[i].ToString()))
            {
                case 0:

                    if (chars[i - 1].ToString() == "1")
                    {
                        output = "Ten" + output;
                    }
                    break;
                case 1:
                    if (i - 1 >= 0 && chars[i - 1].ToString() == "1")
                    {
                        output = "Eleven" + output;
                    }
                    else
                    {
                        output = "One" + output;
                    }
                    break;
                case 2:
                    if (i - 1 >= 0 && chars[i - 1].ToString() == "1")
                    {
                        output = "Twelve " + output;
                    }
                    else
                    {
                        output = "Two" + output;
                    }
                    break;
                case 3:
                    if (i - 1 >= 0 && chars[i - 1].ToString() == "1")
                    {
                        output = "Thirteen " + output;
                    }
                    else
                    {
                        output = "Three" + output;
                    }
                    break;
                case 4:
                    if (i - 1 >= 0 && chars[i - 1].ToString() == "1")
                    {
                        output = "Fourteen " + output;
                    }
                    else
                    {
                        output = "Four" + output;
                    }
                    break;
                case 5:
                    if (i - 1 >= 0 && chars[i - 1].ToString() == "1")
                    {
                        output = "Fifteen " + output;
                    }
                    else
                    {
                        output = "Five" + output;
                    }
                    break;
                case 6:
                    if (i - 1 >= 0 && chars[i - 1].ToString() == "1")
                    {
                        output = "Sixteen " + output;
                    }
                    else
                    {
                        output = "Six" + output;
                    }
                    break;
                case 7:
                    if (i - 1 >= 0 && chars[i - 1].ToString() == "1")
                    {
                        output = "Seventeen " + output;
                    }
                    else
                    {
                        output = "Seven" + output;
                    }
                    break;
                case 8:
                    if (i - 1 >= 0 && chars[i - 1].ToString() == "1")
                    {
                        output = "Eighteen " + output;
                    }
                    else
                    {
                        output = "Eight" + output;
                    }
                    break;
                case 9:
                    if (i - 1 >= 0 && chars[i - 1].ToString() == "1")
                    {
                        output = "Nineteen " + output;
                    }
                    else
                    {
                        output = "Nine" + output;
                    }
                    break;
            }
        }
        else if (cyclecount == 1)
        {
            //tens
            switch (int.Parse(chars[i].ToString()))
            {
                case 2:
                    output = "Twenty" + output;
                    break;
                case 3:
                    output = "Thirty" + output;
                    break;
                case 4:
                    output = "Fourty" + output;
                    break;
                case 5:
                    output = "Fifty" + output;
                    break;
                case 6:
                    output = "Sixty" + output;
                    break;
                case 7:
                    output = "Seventy" + output;
                    break;
                case 8:
                    output = "Eighty" + output;
                    break;
                case 9:
                    output = "Ninety" + output;
                    break;
            }
        }
        else if (cyclecount == 2)
        {
            //hundreds
            switch (int.Parse(chars[i].ToString()))
            {
                case 1:
                    output = "One Hundred and " + output;
                    break;
                case 2:
                    output = "Two Hundred and " + output;
                    break;
                case 3:
                    output = "Three Hundred and " + output;
                    break;
                case 4:
                    output = "Four Hundred and " + output;
                    break;
                case 5:
                    output = "Five Hundred and " + output;
                    break;
                case 6:
                    output = "Six Hundred and " + output;
                    break;
                case 7:
                    output = "Seven Hundred and " + output;
                    break;
                case 8:
                    output = "Eight Hundred and " + output;
                    break;
                case 9:
                    output = "Nine Hundred and " + output;
                    break;
            }
        }
        cyclecount++;
    }
    Console.WriteLine($"{output}");
}
catch (Exception)
{
    Console.WriteLine("INVALID ENTRY");
}


Console.Read();