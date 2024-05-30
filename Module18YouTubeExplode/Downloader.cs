using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18YouTubeExplode
{
    public class Downloader
    {
        Command _command;
        
        public void SetCommand(Command command)
        {
            _command = command;
        }
        
        public async Task RunTask(string videoUrl)
        {
            await _command.RunTask(videoUrl);
        }
    }
}
