using System;
using System.Collections.Generic;

namespace SpotifyTracks.Controllers.Models
{
    public class Artist
    {
        public ExternalUrls external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class ExternalUrls
    {
        public string spotify { get; set; }
    }


    public class Album
    {
        public string album_type { get; set; }
        public List<Artist> artists { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string release_date { get; set; }
        public string type { get; set; }
    }

    public class Track
    {
        public Album album { get; set; }
        public List<Artist> artists { get; set; }
        public int disc_number { get; set; }
        public int duration_ms { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public int popularity { get; set; }
        public int track_number { get; set; }
        public string type { get; set; }
    }

    public class Item
    {
        public Track track { get; set; }
        public DateTime played_at { get; set; }
    }

    public class Root
    {
        public List<Item> items { get; set; }
        public string next { get; set; }
        public int limit { get; set; }
        public string href { get; set; }
    }
}
