namespace API_Gateway_Track_And_Alert.Models;

[Flags]
public enum Roles
{
    User = 1,
    Admin = 2,
    CollarManager = 4,
    Researcher = 8
}
