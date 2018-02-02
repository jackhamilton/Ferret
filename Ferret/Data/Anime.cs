using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferret.Data
{
    class Anime : IComparable, IEquatable<Anime>
    {
        private String title;
        private String posterLink;

        public Anime() : this("", null) {}

        public Anime(String title, String posterLink)
        {
            Title = title;
            PosterLink = posterLink;
        }

        public string Title { get => title; set => title = value; }
        public String PosterLink { get => posterLink; set => posterLink = value; }

        public int CompareTo(object obj)
        {
            Anime anime = (Anime)obj;
            return String.Compare(title, anime.Title);
        }

        public bool Equals(Anime other)
        {
            return CompareTo(other) == 0;
        }
    }
}
