using System.ComponentModel.DataAnnotations;
using Shield.DataAccess.Enums;

namespace Shield.DataAccess.Models;
public class CrewCall
{
    [Key]
    public int CallId { get; set; }
    public int CrewId { get; set; }
    public int ContractId { get; set; }
    public CrewCallStatus Status { get; set; }
    public string? Comment { get; set; }
}
