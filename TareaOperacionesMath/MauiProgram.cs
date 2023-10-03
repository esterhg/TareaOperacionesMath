namespace TareaOperacionesMath
{
    using CommunityToolkit.Maui;

    public class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit();

            return builder.Build();
        }
    }
}
