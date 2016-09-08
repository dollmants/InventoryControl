using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryControl
{
    public static class Musicians
    {
        #region Static Methods
        /// <summary>
        /// Add a music artist to the list.
        /// </summary>
        /// <param name="artist">The artist to be added to the list.</param>
        public static void AddMusicArtist(MusicArtist artist)
        {
            if (IsInitialized() && !MusicArtists.Contains(artist))
                MusicArtists.Add(artist);

            //If the artist is not in thge list, then he/she is probably
            // not in the database either, so add him/her.
            AddMusicianToDatabase(artist);
        }

        /// <summary>
        /// Initializes the list of music artists.
        /// </summary>
        /// <returns>True, if the list has been initialized.</returns>
        public static bool IsInitialized()
        {
            if (MusicArtists == null)
                MusicArtists = new List<MusicArtist>();

            return true;
        }

        /// <summary>
        /// Adds a new artist data row to the data table.
        /// </summary>
        /// <param name="artist">The music artist to be added to the database.</param>
        /// <returns></returns>
        private static void AddMusicianToDatabase(MusicArtist artist)
        {
            using (InventoryControlDataSet.tbl_MusicArtistDataTable musiciansDataTable =
                new InventoryControlDataSet.tbl_MusicArtistDataTable())
            {
                using (InventoryControlDataSetTableAdapters.tbl_MusicArtistTableAdapter adapter =
                    new InventoryControlDataSetTableAdapters.tbl_MusicArtistTableAdapter())
                {
                    DataRow row = musiciansDataTable.NewRow();
                    row["FirstName"] = artist.FirstName;
                    row["MiddleName"] = artist.MiddleName;
                    row["LastName"] = artist.LastName;
                    row["BirthDate"] = artist.BirthDate.ToShortDateString();
                    row["DeathDate"] = artist.DeathDate.ToShortDateString();
                    musiciansDataTable.Rows.Add(row);
                    //Call the adapter to update the data table.
                    adapter.Update(musiciansDataTable);
                }
            }
        }

        /// <summary>
        /// Fetches a list of musicians from the database.
        /// </summary>
        /// <returns></returns>
        public static List<MusicArtist> GetMusiciansFromDatabase()
        {
            List<MusicArtist> artists = new List<MusicArtist>();


            return artists;
        }
        #endregion

        #region Static Properties
        public static List<MusicArtist> MusicArtists { get; private set; }
        #endregion
    }
}
