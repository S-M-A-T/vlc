using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace vlc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

       private async void BtnPlay_Click(object sender, EventArgs e)
{
    try
    {
        var streamUrl = await GetYouTubeStreamUrl(txtVideoUrl.Text);
        if (streamUrl != null)
        {
            var mediaOptions = new[] { ":network-caching=300" };
            vlcControl.Play(new Uri(streamUrl), mediaOptions);
        }
        else
        {
            MessageBox.Show("Unable to retrieve stream URL.");
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error: " + ex.Message);
    }
}


        private void BtnStop_Click(object sender, EventArgs e)
        {
            vlcControl.Stop();
        }

        private async Task<string> GetYouTubeStreamUrl(string videoUrl)
        {
            var youtube = new YoutubeClient();
            var videoId = YoutubeExplode.Videos.VideoId.Parse(videoUrl);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            return streamInfo?.Url;
        }
    }
}
