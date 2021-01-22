using System;

namespace Hello
{
    class DbMigrator
    {
        private readonly ILogger logger;
        public DbMigrator(ILogger logger)
        {
            this.logger = logger;
        }
        public void Migrate()
        {
            logger.InfoLog("Migration Started At : " + DateTime.Now);
            logger.InfoLog("Migration Ended At : " + DateTime.Now);
            logger.Error("Errors : " + 0);
        }
    }
}
