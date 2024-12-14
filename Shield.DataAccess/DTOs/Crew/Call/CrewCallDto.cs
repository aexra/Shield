using Shield.DataAccess.Enums;

namespace Shield.DataAccess.DTOs;
public class CrewCallDto
{
    public int CallId { get; set; }
    public int CrewId { get; set; }
    public int ContractId { get; set; }
    public CrewCallStatus Status { get; set; }
    public string? Comment { get; set; }
}
