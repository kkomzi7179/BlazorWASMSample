namespace BlazorApp.Services
{
    public interface IThemeService
    {
        public const string DefaultTheme = "Default";
        public static readonly string[] SupportedThemeList = new[]
        {
            DefaultTheme,
            "Cerulean",
            "Cosmo",
            "Cyborg",
            "Darkly",
            "Flatly",
        };
        string CurrentTheme { get; }
        Task ToggleTheme(string themeName);
    }
    public class ThemeService : IThemeService
    {
        public string CurrentTheme { get; private set; } = IThemeService.DefaultTheme;

        public async Task ToggleTheme(string themeName)
        {
            CurrentTheme = themeName;
            await Task.CompletedTask;
        }
    }
}
