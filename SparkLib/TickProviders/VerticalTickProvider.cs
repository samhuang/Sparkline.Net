using System.IO;
using System.Text;

namespace SparkNet.TickProviders
{
    /// <summary>
    /// Provides spark characters included within MS Gothic font shipped with
    /// Microsoft Windows. Does not work on cmd.exe shell or PowerShell.
    /// </summary>
    public class VerticalTickProvider : ITickProvider
    {
        private readonly char[] _ticks = new char[] { '▏', '▎', '▍', '▌' ,'▋', '▊', '▉','█'};

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
            if (ticks.Length == 0)
            {
                return string.Empty;
            }
            
            var ret = new StringBuilder();
            ret.Append(ticks[0]);
            for (int index = 1; index < ticks.Length; index++)
            {
                ret.AppendLine().Append(ticks[index]);
            }
            
            return ret.ToString();
        }
    }
}