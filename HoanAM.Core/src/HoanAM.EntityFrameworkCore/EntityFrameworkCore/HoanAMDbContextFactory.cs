using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using HoanAM.Configuration;
using HoanAM.Web;

namespace HoanAM.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HoanAMDbContextFactory : IDesignTimeDbContextFactory<HoanAMDbContext>
    {
        public HoanAMDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HoanAMDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HoanAMDbContextConfigurer.Configure(builder, configuration.GetConnectionString(HoanAMConsts.ConnectionStringName));

            return new HoanAMDbContext(builder.Options);
        }
    }
}
