namespace Touring;

public static class TouringDbProperties
{
    public static string DbTablePrefix { get; set; } = "Touring";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Touring";
}
