using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferret.Data
{
    class AnimeLibrary
    {
        private static List<Anime> currentlyWatching = new List<Anime>();
        private static List<Anime> planToWatch = new List<Anime>();
        private static List<Anime> onHold = new List<Anime>();
        private static List<Anime> dropped = new List<Anime>();
        private static List<Anime> completed = new List<Anime>();

        public static void addCurrentlyWatching(Anime anime)
        {
            if (!currentlyWatching.Contains(anime)) {
                currentlyWatching.Add(anime);
            }
        }

        public static void addPlanToWatch(Anime anime)
        {
            if (!planToWatch.Contains(anime))
            {
                planToWatch.Add(anime);
            }
        }

        public static void addOnHold(Anime anime)
        {
            if (!onHold.Contains(anime))
            {
                onHold.Add(anime);
            }
        }

        public static void addDropped(Anime anime)
        {
            if (!dropped.Contains(anime))
            {
                dropped.Add(anime);
            }
        }

        public static void addCompleted(Anime anime)
        {
            if (!completed.Contains(anime))
            {
                completed.Add(anime);
            }
        }

        public static List<Anime> getCurrentlyWatching()
        {
            return currentlyWatching;
        }

        public static List<Anime> getPlanToWatch()
        {
            return planToWatch;
        }

        public static List<Anime> getOnHold()
        {
            return onHold;
        }

        public static List<Anime> getDropped()
        {
            return dropped;
        }

        public static List<Anime> getCompleted()
        {
            return completed;
        }
    }
}
