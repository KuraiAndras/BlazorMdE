using Microsoft.AspNetCore.Components;

namespace BlazorMdE
{
    public partial class MarkdownEditor
    {
        private bool ShowPreview { get; set; } = false;
        private bool ShowLive { get; set; } = false;
        [Parameter] public string Content { get; set; } = string.Empty;

        private void BoldClicked()
        {
            throw new System.NotImplementedException();
        }

        private void ItalicClicked()
        {
            throw new System.NotImplementedException();
        }

        private void HeadingClicked()
        {
            throw new System.NotImplementedException();
        }

        private void QuoteClicked()
        {
            throw new System.NotImplementedException();
        }

        private void GenericListClicked()
        {
            throw new System.NotImplementedException();
        }

        private void NumberedListClicked()
        {
            throw new System.NotImplementedException();
        }

        private void LinkClicked()
        {
            throw new System.NotImplementedException();
        }

        private void ImageClicked()
        {
            throw new System.NotImplementedException();
        }

        private void PreviewClicked()
        {
            if (ShowLive && !ShowPreview)
            {
                ShowLive = false;
            }

            ShowPreview = !ShowPreview;
        }

        private void SideBySideClicked()
        {
            if (ShowPreview && !ShowLive)
            {
                ShowPreview = false;
            }

            ShowLive = !ShowLive;
        }

        private void FullScreenClicked()
        {
            throw new System.NotImplementedException();
        }

        private void HelpClicked()
        {
            throw new System.NotImplementedException();
        }
    }
}
