

namespace GameZon.ViewModel
{
    public class CreateGameFormViewModel : GameFormViewModel
    {
        [AllowedExtentions(FileSetting.
            allowdEtentions), MaxFileSize(FileSetting.maxFileSizeInBytes)]
        public IFormFile Cover { get; set; } = default!;
    }
}
