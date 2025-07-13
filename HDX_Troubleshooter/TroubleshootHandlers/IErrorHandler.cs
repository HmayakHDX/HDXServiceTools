namespace HDX_ServiceTools.TroubleshootHandlers
{
    public interface IErrorHandler
    {
        bool Handle(Action<string> updateStatus);
    }
}