using MauiIcons.FontAwesome.Solid;
using MauiIcons.Material;
using Microsoft.Extensions.Logging;

namespace Labo4_PxlPop
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Helvetica-Neue-Bold-Extended.ttf", "Helvetica");
                    fonts.AddFont("Arial.ttf", "Arial");
                })

                .UseFontAwesomeSolidMauiIcons();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
