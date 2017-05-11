using log4net;
using ProjectManager.Core.Contracts;

namespace ProjectManager.Core.Providers
{
    public class FileLogger : IFileLogger
    {
        private static ILog logger;

        static FileLogger()
        {
            logger = LogManager.GetLogger(typeof(FileLogger));
        }

        public void Info(object msg)
        {
            logger.Info(msg);
        }     
           
        public void Error(object msg)
        {
            logger.Error(msg);
        }    
            
        public void Fatal(object msg)
        {
            logger.Fatal(msg);
        }
    }
}