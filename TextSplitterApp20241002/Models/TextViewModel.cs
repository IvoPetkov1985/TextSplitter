using System.ComponentModel.DataAnnotations;
using static TextSplitterApp20241002.Models.Constants.ValidationConstants;

namespace TextSplitterApp20241002.Models
{
    public class TextViewModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(TextMaximumLength, MinimumLength = TextMinimumLength, ErrorMessage = LengthMessage)]
        public string Text { get; set; } = string.Empty;

        public string SplitText { get; set; } = string.Empty;
    }
}
