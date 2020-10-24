CRUD operation with SQL compact 4.0
Download SQL compact 4.0 https://www.microsoft.com/en-in/download/details.aspx?id=30709
Install Nuget Package of Entity Framework and EntityFramework.SqlServerCompact

After installing EntityFramework.SqlServerCompact 

App.Config is updated as below 

<entityFramework>
        <providers>
            <provider invariantName="System.Data.SqlClient" type="System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer"/>
            <provider invariantName="System.Data.SqlServerCe.4.0"
                type="System.Data.Entity.SqlServerCompact.SqlCeProviderServices, EntityFramework.SqlServerCompact"/>
        </providers>
        <defaultConnectionFactory type="System.Data.Entity.Infrastructure.SqlCeConnectionFactory, EntityFramework">
            <parameters>
                <parameter value="System.Data.SqlServerCe.4.0"/>
            </parameters>
        </defaultConnectionFactory>
    </entityFramework>


Database Context class

class CRUDAppDBContext : DbContext
    {
        public CRUDAppDBContext() : base("db_CRUD_Demo") { }
        public DbSet<Entities.Student> Students { get; set; }
    }

database file would be created by name db_CRUD_Demo
