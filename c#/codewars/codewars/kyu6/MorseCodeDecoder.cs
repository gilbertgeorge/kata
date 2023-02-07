namespace codewars.kyu6;

public class MorseCodeDecoder
{
    private const string WORD_SEPARATOR = "   ";
    private const string LETTER_SEPARATOR = " ";
    private static readonly Dictionary<string, string> MorseCode = new Dictionary<string, string>
    {
        {".-", "A"},
        {"-...", "B"},
        {"-.-.", "C"},
        {"-..", "D"},
        {".", "E"},
        {"..-.", "F"},
        {"--.", "G"},
        {"....", "H"},
        {"..", "I"},
        {".---", "J"},
        {"-.-", "K"},
        {".-..", "L"},
        {"--", "M"},
        {"-.", "N"},
        {"---", "O"},
        {".--.", "P"},
        {"--.-", "Q"},
        {".-.", "R"},
        {"...", "S"},
        {"-", "T"},
        {"..-", "U"},
        {"...-", "V"},
        {".--", "W"},
        {"-..-", "X"},
        {"-.--", "Y"},
        {"--..", "Z"},
        {".----", "1"},
        {"..---", "2"},
        {"...--", "3"},
        {"....-", "4"},
        {".....", "5"},
        {"-....", "6"},
        {"--...", "7"},
        {"---..", "8"},
        {"----.", "9"},
        {"-----", "0"},
        {"...---...", "SOS"},
        {"-.-.--", "!"},
        {".-.-.-","."},
        {"--..--",","}
    };
    
    private static string GetLetter(string morseCode)
    {
        return MorseCode.ContainsKey(morseCode) ? MorseCode[morseCode] : "";
    }
    
    public static string Decode(string morseCode)
    {
        var words = morseCode.Split(WORD_SEPARATOR);
        var result = "";
        foreach (var word in words)
        {
            var letters = word.Split(LETTER_SEPARATOR);
            foreach (var letter in letters)
            {
                result += GetLetter(letter);
            }
            result += " ";
        }
        return result.Trim();
    }
}