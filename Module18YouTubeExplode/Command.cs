using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18YouTubeExplode
{
    public abstract class Command
    {
        public abstract Task RunTask(string videoUrl);
    }
}
