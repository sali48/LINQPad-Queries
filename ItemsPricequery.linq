<Query Kind="Expression">
  <Connection>
    <ID>749a8c5a-a378-4264-87ad-dc6f62a224aa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//Waiters

/*from x in Waiters              //Query syntax : rest of the query
where x.FirstName.Contains("A")  // method syntax
orderby x.LastName
select x.LastName + ", " + x.FirstName*/

from x in Items
where x.CurrentPrice > 5.00m
select new {
		x.Description,
		x.Calories
}

