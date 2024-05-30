using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Module18YouTubeExplode
{
    public class Download : Command
    {
        YoutubeClient _videoClient;

        public Download(YoutubeClient videoClient)
        {
            _videoClient = videoClient;
        }

        public override async Task RunTask(string videoUrl)
        {
            Console.WriteLine();
            Console.WriteLine("Downloading video...");
            string fileName = "youtube_video.mp4";

            await _videoClient.Videos.DownloadAsync(videoUrl, fileName,
                builder => builder.SetPreset(ConversionPreset.UltraFast) //speed up a bit
            );

            Console.WriteLine("Video downloaded!");
            
        }
    }
}
