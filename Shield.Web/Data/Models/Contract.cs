namespace Shield.Web.Data.Models;

public class Contract
{
    public int Id { get; set; }
    public string Address { get; set; } = string.Empty;
    public string PlanSrc { get; set; } = string.Empty;
    public string Owners { get; set; } = string.Empty;
    public string Bailee { get; set; } = string.Empty;
}
