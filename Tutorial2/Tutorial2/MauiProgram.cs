using Microsoft.Extensions.Logging;
using Prism.Maui; // <-- This fixes the errors
using Tutorial2;
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
                        // ...
                        container.RegisterForNavigation<MainPage, MainPageViewModel>();
                    })
                    .OnAppStart(app => // <--- This method is now found
                    {
                        app.NavigateAsync("MainPage");
                    });
                });
                // ...
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}