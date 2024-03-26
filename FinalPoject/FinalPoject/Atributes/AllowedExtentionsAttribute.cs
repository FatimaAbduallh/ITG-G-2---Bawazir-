namespace GameZon.Atributes
{
    public class AllowedExtentionsAttribute:ValidationAttribute
    {
        private readonly string _allowdExtentions;
        public AllowedExtentionsAttribute(string allowedExtentions)
        {
            _allowdExtentions = allowedExtentions;  
        }
        protected override ValidationResult? IsValid
            (object? value, ValidationContext validationContext)
        {

            var file = value as IFormFile;
            if (file is not null)
            {
                var extention=Path.GetExtension(file.FileName);
                var isAllowed=_allowdExtentions
                    .Split(separator:',')
                    .Contains(extention
                    ,StringComparer.OrdinalIgnoreCase);
                if (!isAllowed)
                {
                    return new ValidationResult
                        (errorMessage: $"only" +
                        $"{_allowdExtentions}" +
                        $" are allowed!");
                }

            }
            return ValidationResult.Success;
        }
       
    }
}
