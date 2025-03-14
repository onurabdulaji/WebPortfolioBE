using WebPortfolio.Domain.Common.Concretes;

namespace WebPortfolio.Domain.Entities;

public class SMedia : EntityBase
{
    public string? Title { get; set; }
    public string? Icon { get; set; }
    public string? Link { get; set; }
    public SMedia()
    {
    }
    public SMedia(string title ,string icon,string link)
    {
        Title = title;
        Icon = icon;
        Link = link;
    }
}
