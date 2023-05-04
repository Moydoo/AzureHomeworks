using System;
using System.Net;

namespace ImageDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://images.unsplash.com/photo-1661956602139-ec64991b8b16?ixlib=rb-4.0.3&ixid=MnwxMjA3fDF8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=665&q=80";
            string localPath = @"C:\data\image.jpg";

            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile(url, localPath);
                    Console.WriteLine("Image downloaded successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error downloading image: {ex.Message}");
                }
            }
        }
    }
}
