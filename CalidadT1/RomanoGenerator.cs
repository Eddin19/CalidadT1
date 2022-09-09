namespace CalidadT1;

public class RomanoGenerator
{
    private Dictionary<int, string> romanos = new Dictionary<int, string>()
    {
        {1000, "M"},
        {500, "D"},
        {100, "C"},
        {50, "L"},
        {10, "X"},
        {5, "V"},
        {1, "I"},
    };
    // si se envia un numero menor a 1 debe enviar error/ validar hasta el 1000
    public string GetRomano(int number)
    {
        var romano = "";
        while (number > 0)
        {
            foreach (KeyValuePair<int, string> entry in romanos)
            {
                if (number < entry.Key) continue;
                romano += entry.Value;
                number -= entry.Key;
                break;
            }
        }

        return romano;
    }
}