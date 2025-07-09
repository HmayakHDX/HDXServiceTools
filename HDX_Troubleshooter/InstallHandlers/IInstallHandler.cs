namespace HDX_ServiceTools.InstallHandlers
{
    public interface IInstallHandler
    {
        /// <summary>
        /// Executes the installation steps asynchronously.
        /// </summary>
        /// <param name="updateStatus">Callback for logging messages to the UI.</param>
        /// <param name="progress">Reports percentage progress to update the progress bar.</param>
        /// <returns>A Task representing the async operation.</returns>
        Task HandleAsync(Action<string> updateStatus, IProgress<int> progress, CancellationToken token);
    }
}