using System.IO;

namespace SparkNet.TickProviders
{
    /// <summary>
    /// Provides spark characters included within MS Gothic font shipped with
    /// Microsoft Windows. Does not work on cmd.exe shell or PowerShell.
    /// </summary>
    public class MsGothicTickProvider : ITickProvider
    {
        private readonly char[] _ticks = new char[] { '▁', '▂', '▃', '▄' ,'▅', '▆', '▇','█'};

        private readonly char[] _ticks2 = new char[] { '▏', '▎', '▍', '▌' ,'▋', '▊', '▉','█'};

        //▬
        //▀
        public char[] Ticks
        {
            get
            {
                return _ticks;
            }
        }

        public string Assemble(char[] ticks)
        {
            return new string(ticks);
        }
    }
}
