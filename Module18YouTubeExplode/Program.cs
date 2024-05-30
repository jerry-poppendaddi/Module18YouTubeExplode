using System;
using System.Text;
using YoutubeExplode;

namespace Module18YouTubeExplode
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello! Please paste the YouTube video URL below:");
            Console.WriteLine();
            var videoUrl = Console.ReadLine();

            var downloader = new Downloader();
            var receiverClient = new YoutubeClient();

            var videoInfo = new VideoInfo(receiverClient);
            downloader.SetCommand(videoInfo);
            await downloader.RunTask(videoUrl);

            var download = new Download(receiverClient);
            downloader.SetCommand(download);
            await downloader.RunTask(videoUrl);

        }

    }
}