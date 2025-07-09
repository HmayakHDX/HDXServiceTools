namespace HDX_ServiceTools.TroubleshootHandlers
{
    public interface IErrorHandler
    {
        void Handle(Action<string> updateStatus);
    }
}