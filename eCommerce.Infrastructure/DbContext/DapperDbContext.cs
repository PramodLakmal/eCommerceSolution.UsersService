﻿using System.Data;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace eCommerce.Infrastructure.DbContext;

internal class DapperDbContext
{

    private readonly IConfiguration _configuration;
    private readonly IDbConnection _connection;
    public DapperDbContext(IConfiguration configuration)
    { 
        _configuration = configuration;

        string? connectionString = _configuration.GetConnectionString("PostgressConnection");

        _connection =  new NpgsqlConnection(connectionString);
    }

    public IDbConnection DbConnection => _connection;
}
