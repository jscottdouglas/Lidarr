﻿using System;
using System.Collections.Generic;
using System.Linq;
using NzbDrone.Core.Music;

namespace NzbDrone.Core.Parser.Model
{
    public class RemoteAlbum
    {
        public ReleaseInfo Release { get; set; }
        public ParsedTrackInfo ParsedTrackInfo { get; set; }
        public Artist Artist { get; set; }
        public List<Album> Albums { get; set; }
        public bool DownloadAllowed { get; set; }

        public bool IsRecentAlbum()
        {
            return Albums.Any(e => e.ReleaseDate >= DateTime.UtcNow.Date.AddDays(-14));
        }

        public override string ToString()
        {
            return Release.Title;
        }
    }
}