﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Album
{
    public interface IAlbumSearcher
    {
        string Search(string directoryPath);
    }
}
