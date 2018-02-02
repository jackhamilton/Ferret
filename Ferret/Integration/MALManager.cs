using Ferret;
using Ferret.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

public class MALManager
{
    private static HttpClient httpClient = new HttpClient();
    private string username;
    private string password;

    public MALManager(string username, string password)
    {
        this.username = username;
        this.password = password;
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue
            ("Basic", Convert.ToBase64String(Encoding.Default.GetBytes(username + ":" + password)));
    }

    public async Task getAnimeList()
    {
        String result = await GET("https://myanimelist.net/malappinfo.php?status=all&type=anime&u=" + username);
        //Parse XML
        //Read the XML file returned by MAL
        using (XmlReader reader = XmlReader.Create(new StringReader(result)))
        {
            //Root node is "myanimelist"
            reader.ReadStartElement("myanimelist");
            if (reader.Name != "myanimelist")
            {
                //First internal node is "myinfo"
                reader.ReadStartElement("myinfo");
                while (reader.Name != "myinfo")
                {
                    XElement el = (XElement)XNode.ReadFrom(reader);
                    //We don't do anything with the myinfo elements yet.
                }
                reader.ReadEndElement();
            }
            //Until it hits the end tag "/myanimelist", read each individual "anime" node and add an element for each.
            while (reader.Name != "myanimelist") {
                reader.ReadStartElement("anime");
                Anime tempAnime = new Anime();
                while (reader.Name != "anime")
                {
                    XElement el = (XElement)XNode.ReadFrom(reader);
                    if (el.Name == "series_title")
                    {
                        tempAnime.Title = el.Value;
                    }
                    if (el.Name == "series_image")
                    {
                        tempAnime.PosterLink = el.Value;
                    }
                    if (el.Name == "my_status")
                    {
                        if (el.Value == "1")
                        {
                            AnimeLibrary.addCurrentlyWatching(tempAnime);
                        } else if (el.Value == "3")
                        {
                            AnimeLibrary.addOnHold(tempAnime);
                        } else if (el.Value == "6")
                        {
                            AnimeLibrary.addPlanToWatch(tempAnime);
                        } else if (el.Value == "4")
                        {
                            AnimeLibrary.addDropped(tempAnime);
                        } else if (el.Value == "2")
                        {
                            AnimeLibrary.addCompleted(tempAnime);
                        }
                    }
                }
                reader.ReadEndElement();
            }
            reader.ReadEndElement();
        }
    }

    //Sends an HTML GET request to the given URL, returns a string asynchronously.
    public async Task<String> GET(string path)
    {
        String product = null;
        HttpResponseMessage response = await httpClient.GetAsync(path);
        if (response.IsSuccessStatusCode)
        {
            product = await response.Content.ReadAsStringAsync();
        }
        return product;

    }

    //Sends an HTML GET request to the given URL, returns a stream asynchronously.
    public async Task<Stream> GETStream(string path)
    {
        Stream product = null;
        HttpResponseMessage response = await httpClient.GetAsync(path);
        if (response.IsSuccessStatusCode)
        {
            product = await response.Content.ReadAsStreamAsync();
        }
        return product;

    }
}