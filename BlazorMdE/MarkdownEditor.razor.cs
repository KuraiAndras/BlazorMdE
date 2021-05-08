using Microsoft.AspNetCore.Components;

namespace BlazorMdE
{
    public partial class MarkdownEditor
    {
        private bool IsEditing { get; set; } = true;
        [Parameter] public string Content { get; set; } = string.Empty;

        private void SwitchEditView() => IsEditing = !IsEditing;
    }
}
