using System.Text;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        var charArray = identifier.ToCharArray();
        StringBuilder sb = new();
        string temp;
        bool convertToCamel = false;
        foreach(char character in charArray)
        {
            if(character == ' ')
                temp = "_";
            else if(char.IsControl(character))
                temp = "CTRL";
            else if(character == '-')
            {
                convertToCamel = true;
                continue;
            }
            else if(convertToCamel)
            {
                convertToCamel = false;
                temp = Char.ToUpper(character).ToString();
            }
            else if(!Char.IsLetter(character))
                continue;
            else if(IsLowerGreekCharacter(character))
                continue;
            else    
                temp = character.ToString();
            
            sb.Append(temp);
        }
        return sb.ToString();
    }

    private static bool IsLowerGreekCharacter(char character)
    {
        const int GreekBlockStart = 0x03B1;
        const int GreekBlockEnd = 0x03C9;
        int codePoint = (int)character;
        return codePoint >= GreekBlockStart && codePoint <= GreekBlockEnd;
    }
}
