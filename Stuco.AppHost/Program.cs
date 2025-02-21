using Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var sql = builder.AddSqlServer("sql")
    .WithLifetime(ContainerLifetime.Persistent);

var db = sql.AddDatabase("database");

builder.AddProject<Projects.Stuco_Api>("api")
    .WithReference(db)
    .WaitFor(db);

builder.AddProject<Projects.Stuco_UI>("frontend")
    .WithReference(db)
    .WaitFor(db);

builder.Build().Run();
