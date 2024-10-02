namespace TextSplitterApp20241002.Models.Constants
{
    public static class ValidationConstants
    {
        public const string RequiredMessage = "Field {0} is required!";
        public const string LengthMessage = "The field {0} must be a string with a minimum length of {2} and maximum length of {1}.";

        public const int TextMinimumLength = 2;
        public const int TextMaximumLength = 30;
    }
}
