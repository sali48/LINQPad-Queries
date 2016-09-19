<Query Kind="Statements">
  <Connection>
    <ID>e9772029-1c54-412e-92ee-497f958e74d3</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

//When you need to use multiple steps 
//to solve a problem switch your language choice
//to either statement or program
//the result of each query will now be save in variable
// the variable can then be used in future queries
var maxcount = (from x in MediaTypes
	select x.Tracks.Count()).Max();
// to display the contents of a variable in Linqpad
// use method .Dump()
maxcount.Dump();
// use a value in a preceeding create variable
var popularMediaType = from x in MediaTypes
						where x.Tracks.Count() == maxcount
						select new{
							type = x.Name,
							tCount = x.Tracks.Count()
						};
popularMediaType.Dump();

//Can this set of statements be seen as one completly query 
//Possibly , in this case yes - Sub Query
// in this example maxcount could be exchanged for the query that
//actually create the value in the first place
//this substituted query is a subquery

from x in MediaTypes
where x.Tracks.Count() == (from y in MediaTypes
select y.Tracks.Count()).Max()
select new{
			type = x.Name,
			tCount = x.Tracks.Count()
}

//hybrid - query syntax and method syntax
//using the method syntax

var popularMediaType = from x in MediaTypes
						where x.Tracks.Count() == 
							MediaTypes.Select (mt => mt.Tracks.Count()).Max()
						select new{
							type = x.Name,
							tCount = x.Tracks.Count()
						};
popularMediaType.Dump();
