namespace TaskManagement.API.SharedData;

public static class Roles
{
    public const string Admin = "admin";
    public const string Manager = "manager";
    public const string User = "user";

    public static IReadOnlyList<string> GetRoles()
        => [Admin, Manager, User];
}
