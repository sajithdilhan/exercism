using System.Text;
static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        StringBuilder result = new();

        if(id != null)
        {
            result.Append( $"[{id.ToString()}] - ");
        }
        result.Append(name);
        if(!string.IsNullOrWhiteSpace(department))
        {
            result.Append($" - {department.ToUpper()}");
        }
        else
        {
            result.Append(" - OWNER");
        }

        return result.ToString();
    }
}
