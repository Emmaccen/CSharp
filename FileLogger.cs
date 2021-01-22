using System.IO;

namespace Hello
{
     enum MessageType
    {
        INFO,
        ERROR
    }

    class FileLogger : ILogger
    {
        private readonly string path;

        public FileLogger(string path)
        {
            this.path = path;
        }
        public void Error(string errorMessage)
        {
            Log(MessageType.ERROR.ToString() + ": " + errorMessage);
        }

        public void InfoLog(string message)
        {
            Log(MessageType.INFO.ToString() + ": " + message);
        }
        private void Log(string message)
        {
            using (StreamWriter stream = new StreamWriter(path, true))
            {
                stream.WriteLine(message);
            }
        }
    }
}