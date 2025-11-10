using Microsoft.Extensions.Logging;
using Prism.Maui; // <-- This fixes the errors
using Tutorial2; // <-- This fixes the 'App' error
using Tutorial2.ViewModels.Pages;

namespace Tutorial2
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UsePrism((prism) =>
                {
                    prism.RegisterTypes(container =>
                    {
                        // This part is from your tutorial, but it's for
                        // a project that MOVED MainPage. You have not.
                        // You may need to update this later.
                        container.RegisterForNavigation<MainPage, MainPageViewModel>();
                    })
                    .OnAppStart(app =>
                    {
                        app.NavigateAsync("MainPage");
                    });
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}