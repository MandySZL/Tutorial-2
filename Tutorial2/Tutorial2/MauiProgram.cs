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
                .UsePrism(prism =>
                {
                    prism.RegisterTypes(container =>
                    {
                        container.RegisterForNavigation<MainPage, MainPageViewModel>();
                    });
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
