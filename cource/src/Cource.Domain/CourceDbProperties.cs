namespace Cource;

public static class CourceDbProperties
{
    public static string DbTablePrefix { get; set; } = "Cource";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Cource";
}
