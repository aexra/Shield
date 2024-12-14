select os.type, os.name, price  from contracts c
join (
	select * from organizations o
	where o.ownerid is not null
) os on os.organizationid = c.organizationid
join owners ows on ows.ownerid = os.ownerid
group by price, os.type, os.name
order by price;