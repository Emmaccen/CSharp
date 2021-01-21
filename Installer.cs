using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class Installer
    {
        private readonly Logger logger;

        public Installer(Logger logger)
        {
            this.logger = logger;
        }
        public void Install()
        {
            logger.Log("Migrating datebase... successful");
        }
    }
}
