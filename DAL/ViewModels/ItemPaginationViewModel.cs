namespace DAL.ViewModels;

public class ItemPaginationViewModel
{   
    public string? Category { get; set; }
    public IEnumerable<ItemViewModel> Items { get; set; }  // List of users
    public int? TotalCount { get; set; }
    public int PageSize { get; set; } = 5;
    public int CurrentPage { get; set; } = 1;
    public int? TotalPages { get; set; }
    public int? StartIndex { get; set; } 
    public int? EndIndex { get; set; }
    public string? SearchKeyword { get; set; } 
}
