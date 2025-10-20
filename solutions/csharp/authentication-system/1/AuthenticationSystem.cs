using System.Collections.ObjectModel;

public class Authenticator
{
    private static class EyeColor
    {
        public const string Blue = "blue";
        public const string Green = "green";
        public const string Brown = "brown";
        public const string Hazel = "hazel";
        public const string Grey = "grey";
    }

    public Authenticator(Identity admin)
    {
        this.admin = admin;
    }

    private Identity admin;

    private ReadOnlyDictionary<string, Identity> developers
        => new ReadOnlyDictionary<string, Identity>(new Dictionary<string, Identity>
        {
            ["Bertrand"] = new Identity
            {
                Email = "bert@ex.ism",
                EyeColor = EyeColor.Blue
            },

            ["Anders"] = new Identity
            {
                Email = "anders@ex.ism",
                EyeColor = EyeColor.Brown
            }
        });


    public Identity Admin
    {
        get { return admin; }
    }

    public IDictionary<string, Identity> GetDevelopers()
    {
        return developers;
    }
}

public struct Identity
{
    public string Email { get; set; }

    public string EyeColor { get; set; }
}
