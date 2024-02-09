using GraphicEditor.Interfaces;
using GraphicEditor.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GraphicEditor
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var serviceProvider = new ServiceCollection()
                .AddTransient<Form1>()
                .AddTransient<IDrawService, DrawService>()
                .AddTransient<IShapeService, ShapeService>()
                .BuildServiceProvider();

            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }
    }
}