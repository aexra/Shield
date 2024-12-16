using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shield.DataAccess.DTOs;
using Vanguard.Web.Data.Contexts;

namespace Shield.Web.Controllers;

[ApiController]
[Route("api/report")]
public class ReportController : ControllerBase
{
    private readonly Vanguard.Web.Data.Contexts.VanguardContext _context;

    public ReportController(Vanguard.Web.Data.Contexts.VanguardContext context)
    {
        _context = context;
    }

    [HttpGet("1")]
    public async Task<IActionResult> GetReport1()
    {
        var result = await _context.Database.SqlQuery<Report1>(@$"
            CREATE TEMP TABLE IF NOT EXISTS OrgsOwners AS
            select organizationid, name, type, ownerid from organizations;

            CREATE TEMP TABLE IF NOT EXISTS OrgsAlarmsCount AS
            select OrganizationId, count(*) from contracts c
            join alarms a on a.ContractId = c.ContractId
            group by c.ContractId;

            CREATE TEMP TABLE IF NOT EXISTS Report1 AS
            select oo.name, oo.type, sum(oac.count), avg(oac.count) from OrgsOwners oo
            join OrgsAlarmsCount oac on oac.OrganizationId = oo.OrganizationId
            group by oo.organizationid, oo.name, oo.type;

            SELECT * FROM Report1;
        ").ToListAsync();

        return Ok(result);
    }

    [HttpGet("2")]
    public async Task<IActionResult> GetReport2()
    {
        var result = await _context.Database.SqlQuery<Report2>(@$"
            select os.type, os.name, price  from contracts c
            join (
	            select * from organizations o
	            where o.ownerid is not null
            ) os on os.organizationid = c.organizationid
            join owners ows on ows.ownerid = os.ownerid
            group by price, os.type, os.name
            order by price;
        ").ToListAsync();

        return Ok(result);
    }

    [HttpGet("3")]
    public async Task<IActionResult> GetReport3()
    {
        var result = await _context.Database.SqlQuery<Report3>(@$"
            select c.crewid, c.name, leaderid, firstname, lastname, middlename, phonenumber from crews c
            join crewmembers cm on cm.memberid = c.leaderid
            join users u on cm.userid = u.userid
        ").ToListAsync();

        return Ok(result);
    }
}
