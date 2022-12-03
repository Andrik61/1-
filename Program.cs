using System;

class Program
{
    static void Main(string[] args)
    {
        string[] ArrayString;
        string[] ArrayString2;
        string[] ArrayString3;
        string[] ArrayString4;
        string AS, AS2;
        int count = 0;
        int count2 = 0;
        string s;

        Console.WriteLine("Enter strings:");
        ArrayString = new string[count];
        ArrayString3 = new string[count];
        do
        {
            s = Console.ReadLine();
            if (s != "")
            {
                count++;
                ArrayString2 = new string[count];
                for (int i = 0; i < ArrayString2.Length - 1; i++)
                    ArrayString2[i] = ArrayString[i];
                ArrayString2[count - 1] = s;
                ArrayString = ArrayString2;
                if (s.Length < 4)
                {
                    count2++;
                    ArrayString4 = new string[count2];
                    for (int i = 0; i < ArrayString4.Length - 1; i++)
                        ArrayString4[i] = ArrayString3[i];
                    ArrayString4[count2 - 1] = s;
                    ArrayString3 = ArrayString4;
                }
            }
        } while (s != "");
        AS = string.Join(", ", ArrayString);
        AS2 = string.Join(", ", ArrayString3);
        Console.Write(AS);
        Console.Write(" -> ");
        Console.WriteLine(AS2);
        Console.ReadKey();
    }
}
