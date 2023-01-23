// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
QueryExecutor qry = new QueryExecutor("WinstonBrand", "eex2tngmzd3vdqzo2twt46akt5lplknjbjsvqd6i65cpf4sbrviq");

Task<IList<WorkItem>>  openBugs = qry.QueryOpenBugs("Phase-ONE");
