namespace GameZon.ViewModel
{
    public class EditGameFormViewModel:GameFormViewModel
    {
       public int Id { get; set; }  
        public string?CurrentCover { get; set; }

        [AllowedExtentions(FileSetting.
            allowdEtentions), MaxFileSize(FileSetting.maxFileSizeInBytes)]
        public IFormFile?Cover { get; set; } = default!;
    }
}
