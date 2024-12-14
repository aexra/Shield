using Microsoft.EntityFrameworkCore;

namespace Shield.DataAccess.Models;

[Keyless]
public class Keyless
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Sum { get; set; }
    public double Avg { get; set; }
}
