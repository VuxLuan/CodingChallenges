using System.Text.RegularExpressions;

class Ccwc
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage : ccwc [-c | -l | -w | -m ] [filename]");
            return;
        }


        string option = args[0];
        string? filename = args.Length > 1 ? args[1] : null;
        string text = "";
        try
        {
            text = filename != null ? File.ReadAllText(filename) : Console.In.ReadToEnd();
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File not foung" + ex);
        }
        int count;
        switch (option)
        {
            case "-c":
                count = GetByteCount(text);
                Console.WriteLine($"{count} {filename}");
                break;
            case "-l":
                count = GetByteCount(text);
                Console.WriteLine($"{count} {filename}");
                break;
            case "-w":
                count = GetWordCount(text);
                Console.WriteLine($"{count} {filename}");
                break;
            case "-m":
                count = GetCharacterCount(text);
                Console.WriteLine($"{count} {filename}");
                break;
            default:
                int lines = GetLineCount(text);
                int words = GetWordCount(text);
                int bytes = GetByteCount(text);
                Console.WriteLine($"{lines,7} {words,9} {bytes,9} {filename}");
                break;
        }
    }

    static int GetByteCount(string text)
    {
        return text.Length;
    }

    static int GetLineCount(string text)
    {
        return Regex.Matches(text, @"\r\n\r|\n").Count + 1;
    }

    static int GetWordCount(string text)
    {
        return Regex.Matches(text, @"[\S]+").Count;
    }

    static int GetCharacterCount(string text)
    {
        return text.Length;
    }
}