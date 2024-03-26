

namespace GameZon.ViewModel
{
    public class CreateGameFormViewModel
    {
        [MaxLength(length: 2500)]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; } = Enumerable.Empty<SelectListItem>();

        [Display(Name = "Supported Devices")]
        public List<int> SelectedDevices { get; set; } = default!;
        public IEnumerable<SelectListItem> Devices { get; set; } = Enumerable.Empty<SelectListItem>();


        [MaxLength(length: 2500)]
        public string Description { get; set; } = string.Empty;
        [AllowedExtentions(FileSetting.
            allowdEtentions), MaxFileSize(FileSetting.maxFileSizeInBytes)]
        public IFormFile Cover { get; set; } = default!;
    }
}
