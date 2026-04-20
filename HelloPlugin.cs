using Krynetic.Database.PluginSystem;

[module: PluginExport(typeof(HelloPlugin))]

[Plugin(
    "Hello",
    Description = "Example plugin that says hello",
    Tags = ["example"],
    Stage = PluginLifecycle.Production,
    Tier = LicenseTier.Community
)]
public static partial class HelloPlugin
{
    [PluginFunction("Hello")]
    public static string Hello() => "Hello";
}
