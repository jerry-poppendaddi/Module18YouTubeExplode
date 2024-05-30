using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace Module18YouTubeExplode
{
    public class VideoInfo : Command
    {
        YoutubeClient _videoClient;

        public VideoInfo(YoutubeClient videoClient)
        {
            _videoClient = videoClient;
        }

        public override async Task RunTask(string videoUrl)
        {
            Console.WriteLine("Download In Process");

            var info = await _videoClient.Videos.GetAsync(videoUrl);
            Console.WriteLine(info.Title);
            Console.WriteLine(info.Description);

        }
    }
}
