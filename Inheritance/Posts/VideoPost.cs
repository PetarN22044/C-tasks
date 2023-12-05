using System;
using System.Threading;

namespace Inheritance.Posts
{
    public class VideoPost : Post
    {
        private bool isPlaying = false;
        private int currentDuration = 0;
        private Timer timer;

        public string VideoUrl { get; set; }
        public int Length { get; set; }

        public VideoPost()
            : base()
        {
        }

        public VideoPost(string title, string sendByUserName, string videoUrl, bool isPublished, int length)
            : base(title, isPublished, sendByUserName)
        {
            VideoUrl = videoUrl;
            Length = length;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {VideoUrl} - {Length} seconds";
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                timer = new Timer(TimerCallback, null, 0, 1000);
                Console.WriteLine("Playing");
            }
            else
            {
                Console.WriteLine("Already playing");
            }
        }

        private void TimerCallback(object o)
        {
            if (currentDuration < Length)
            {
                currentDuration++;
                Console.WriteLine($"Video at {currentDuration}s");
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                Console.WriteLine($"Stopped at {currentDuration}s");
                currentDuration = 0;
                isPlaying = false;
                timer.Dispose();
            }
            else
            {
                Console.WriteLine("Not playing");
            }
        }
    }
}
