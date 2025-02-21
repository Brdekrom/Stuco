using Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var mssqlServer = builder.AddSqlServer("sql")
    .WithDataVolume()
    .WithLifetime(ContainerLifetime.Persistent);

var stucoDb = mssqlServer.AddDatabase("StucoDB");

builder.AddProject<Projects.Stuco_Api>("api")
    .WithReference(stucoDb)
    .WaitFor(stucoDb);

builder.AddProject<Projects.Stuco_UI>("frontend")
    .WithReference(stucoDb)
    .WaitFor(stucoDb);

builder.Build().Run();
