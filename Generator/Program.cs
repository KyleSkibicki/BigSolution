// See https://aka.ms/new-console-template for more information

for (int j = 1; j <= 50000; j++)
{
    using (StreamWriter writetext = new StreamWriter($@"C:\Users\kyles\source\repos\BigSolution\BigProject\Classes\Class{j:D5}.cs"))
    {
        writetext.WriteLine("using System;");
        writetext.WriteLine("namespace BigProject");
        writetext.WriteLine("{");

        writetext.WriteLine($"    class MyClass{j:D3}");
        writetext.WriteLine("    {");

        /*
         * Without this code generated, 10 seconds to 1:30 with EnableNETAnalyzers and RunAnalyzersDuringBuild false/true
         * With this code generated, 1:20 to4:30 with EnableNETAnalyzers and RunAnalyzersDuringBuild false/true
        */
        
        /*
        writetext.WriteLine("public delegate bool MyReplaceFunction(string s, out string t);");

        writetext.WriteLine("          private static void UpdateBrowseLoader1(string file)        {            Console.WriteLine(file);}");
        writetext.WriteLine("          private static void UpdateBrowseLoader2(string file)        {            Console.WriteLine(file);}");
        writetext.WriteLine("          private static void UpdateBrowseLoader3(string file)        {            Console.WriteLine(file);}");
        writetext.WriteLine("          private static void UpdateBrowseLoader4(string file)        {            Console.WriteLine(file);}");
        writetext.WriteLine("          private static void UpdateBrowseLoader5(string file)        {            Console.WriteLine(file);}");
        writetext.WriteLine("          private static void UpdateBrowseLoader6(string file)        {            Console.WriteLine(file);}");
        writetext.WriteLine("          private static void UpdateBrowseLoader7(string file)        {            Console.WriteLine(file);}");
        writetext.WriteLine("          private static void UpdateBrowseLoader8(string file)        {            Console.WriteLine(file);}");
        */

        writetext.WriteLine("}");
        writetext.WriteLine("}");
    }
}

Console.WriteLine("Done");