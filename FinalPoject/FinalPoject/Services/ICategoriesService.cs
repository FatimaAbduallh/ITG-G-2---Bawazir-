namespace GameZon.Services
{
    public interface ICategoriesService
    {
        IEnumerable<SelectListItem> GetSelectList();

    }
}
