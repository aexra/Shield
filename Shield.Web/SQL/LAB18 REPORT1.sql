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