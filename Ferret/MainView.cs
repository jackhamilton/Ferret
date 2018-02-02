using Ferret.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferret
{
    public partial class MainView : Form
    {
        private static Model currentlyWatchingModel, planToWatchModel,
            onHoldModel, droppedModel, completedModel;
        private static string username = "FerretMALTestAcc", password = "FerretMALManager";

        public MainView()
        {
            InitializeComponent();
            loadMALData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private async void loadMALData()
        {
            MALManager manager = new MALManager(username, password);
            await manager.getAnimeList();
            currentlyWatchingModel = new Model(currentlyWatchingList);
            planToWatchModel = new Model(planToWatchList);
            onHoldModel = new Model(onHoldList);
            droppedModel = new Model(droppedList);
            completedModel = new Model(completedList);
            loadAnimeList(AnimeLibrary.getCurrentlyWatching(), currentlyWatchingModel);
            loadAnimeList(AnimeLibrary.getPlanToWatch(), planToWatchModel);
            loadAnimeList(AnimeLibrary.getOnHold(), onHoldModel);
            loadAnimeList(AnimeLibrary.getDropped(), droppedModel);
            loadAnimeList(AnimeLibrary.getCompleted(), completedModel);
        }

        private static void loadAnimeList(List<Anime> animes, Model model)
        {
            if (!model.Loaded)
            {
                WebClient wc = new WebClient();
                for (int x = 0; x < animes.Count; x++)
                {
                    if (animes[x].PosterLink != null)
                    {
                        byte[] bytes = wc.DownloadData(animes[x].PosterLink);
                        MemoryStream ms = new MemoryStream(bytes);
                        System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                        model.addViewElement(animes[x].Title, img);
                    }
                    else
                    {
                        Console.Error.Write("Image for anime \"" + animes[x].Title + "\" stored as null in MALManager.");
                    }
                }
                model.Loaded = true;
            }
        }
    }
}
