using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Album
{
    public class AlbumSearcher : IAlbumSearcher
    {
        /** Search for an Album
         * 
         *      This function should take in a String. The string should be the path to a directory.
         *      
         *      The function should search a database for an Album with a matching path.
         *      If found, the function should return an IAlbum object.
         *      
         */
        public string Search(string directoryPath)
        {
            // ToDo: Implement this function
            return directoryPath;
        }
    }
}
