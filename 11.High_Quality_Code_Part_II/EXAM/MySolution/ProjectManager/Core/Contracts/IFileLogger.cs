namespace ProjectManager.Core.Contracts
{
    public interface IFileLogger
    {
        void Info(object msg);

        void Error(object msg);

        void Fatal(object msg);
    }
}
