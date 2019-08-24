using System.Collections.Generic;

namespace SparkNet
{
    public interface ITickProvider
    {
        char[] Ticks { get; }

        string Assemble(char[] res);
    }
}
