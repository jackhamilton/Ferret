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
        private static Model model;
        private static string username = "jackham8", password = "Blacklight1337";

        public MainView()
        {
            InitializeComponent();
            model = new Model(getMainListView());
            getList();
        }

        public ListView getMainListView()
        {
            return currentlyWatchingList;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private static async void getList()
        {
            MALManager manager = new MALManager(username, password);
            Tuple<List<String>, List<String>> animes = await manager.getAnimeList();
            WebClient wc = new WebClient();
            for (int x = 0; x < animes.Item1.Count; x++)
            {
                byte[] bytes = wc.DownloadData(animes.Item2[x]);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                model.addViewElement(animes.Item1[x], img);
            }
        }
    }
}
