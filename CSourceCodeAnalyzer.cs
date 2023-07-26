using System;
using System.IO;
using System.Text.RegularExpressions;

public class FunctionNameExtractor
{
    public static void Main()
    {
        string path = @"C:\path\to\your\c\source.c"; // C言語ソースコードへのパスを指定します

        string pattern = @"(\w+)\s+(\w+)\s*\((.*?)\)"; // 基本的な関数宣言の正規表現パターン

        string[] lines = File.ReadAllLines(path);

        foreach (var line in lines)
        {
            var match = Regex.Match(line, pattern);

            if (match.Success)
            {
                Console.WriteLine("Function name: " + match.Groups[2].Value); // 抽出した関数名を表示します
            }
        }
    }
}
