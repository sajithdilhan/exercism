[Flags]
public enum AccountType
{
    Guest = 1,
    User = 2,
    Moderator = 4
}

[Flags]
public enum Permission
{
    None = 0,
    Read = 1,
    Write = 2,
    Delete = 4,
    All = 7
}

static class Permissions
{
    public static Permission Default(AccountType accountType)
    {
        Permission permission = accountType switch
        {
              AccountType.Guest =>  Permission.Read,
              AccountType.User => Permission.Read | Permission.Write,
              AccountType.Moderator => Permission.All,
              _ => Permission.None
        };

        return permission;
    }

    public static Permission Grant(Permission current, Permission grant)
    {
        current |= grant;
        return current;
    }

    public static Permission Revoke(Permission current, Permission revoke)
    {
        current &= ~revoke;
        return current;
    }

    public static bool Check(Permission current, Permission check) => current.HasFlag(check);
}
