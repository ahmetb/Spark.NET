namespace SparkNet.TickProviders
{
    /// <summary>
    /// Provides ascii characters for chart, shell-friendly.
    /// </summary>
    public class AsciiTickProvider : ITickProvider
    {
        private readonly char[] _ticks = new char[] { '_', '.', 'ı', 'l', '|'};

        public char[] Ticks
        {
            get
            {
                return _ticks;
            }
        }
    }
}
