using Ganss.XSS;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorMdE
{
    public static class Injector
    {
        public static IServiceCollection AddBlazorMdE(this IServiceCollection services, HtmlSanitizer? sanitizer = null)
        {
            services.AddTransient<IHtmlSanitizer, HtmlSanitizer>(_ =>
            {
                if (sanitizer is not null) return sanitizer;

                sanitizer = new HtmlSanitizer();
                sanitizer.AllowedAttributes.Add("class");
                return sanitizer;
            });

            return services;
        }
    }
}
