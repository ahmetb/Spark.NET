namespace SparkNet.TickProviders
{
    /// <summary>
    /// Provides spark characters included within MS Gothic font shipped with
    /// Microsoft Windows. Does not work on cmd.exe shell or PowerShell.
    /// </summary>
    public class MsGothicTickProvider : ITickProvider
    {
        private readonly char[] _ticks = new char[] { '▁', '▂', '▃', '▄' ,'▅', '▆', '▇','█'};

        public char[] Ticks
        {
            get
            {
                return _ticks;
            }
        }
    }
}
