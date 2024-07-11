using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");
var sqlServer = builder.AddSqlServer("sqlServer")
    // Mount the init scripts directory into the container.
    .WithBindMount("./SqlServerConfig", "/usr/config")
    // Mount the SQL scripts directory into the container so that the init scripts run.
    .WithBindMount("./Data", "/docker-entrypoint-initdb.d")
    // Run the custom entrypoint script on startup.
    .WithEntrypoint("/usr/config/entrypoint.sh");

var demoApi = builder.AddProject<DemoProject_Api>("demoapi")
    .WithReference(cache)
    .WithReference(sqlServer);

builder.Build().Run();