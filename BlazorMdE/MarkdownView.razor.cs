using Ganss.XSS;
using Markdig;
using Microsoft.AspNetCore.Components;

namespace BlazorMdE
{
    public partial class MarkdownView
    {
        private string _content = string.Empty;

        [Inject] public IHtmlSanitizer HtmlSanitizer { get; init; } = default!;

        [Parameter]
        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                HtmlContent = ConvertStringToMarkupString(_content);
            }
        }

        [Parameter]
        public string? Class { get; set; }

        public MarkupString HtmlContent { get; private set; }

        private MarkupString ConvertStringToMarkupString(string value)
        {
            if (string.IsNullOrWhiteSpace(_content)) return new MarkupString();

            var html = Markdown.ToHtml(value, new MarkdownPipelineBuilder().UseAdvancedExtensions().Build());

            var sanitizedHtml = HtmlSanitizer.Sanitize(html);

            return new MarkupString(sanitizedHtml);
        }
    }
}
