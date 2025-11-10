using Microsoft.Extensions.Logging;
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
                .UsePrism(static (prism) =>
                {
                    // RegisterTypes returns void, so you can't chain methods from it.
                    prism.RegisterTypes(container =>
                    {
                        // ...
                        container.RegisterForNavigation<MainPage, MainPageViewModel>();
                    }); // <-- End the RegisterTypes statement here.

                    // Call OnAppStart on the 'prism' variable directly.
                    prism.OnAppStart(app =>
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