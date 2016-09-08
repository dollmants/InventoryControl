using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryControl
{
    /// <summary>
    /// Object class to hold values for the Compact Disc (CD).
    /// </summary>
    public class CompactDisc
    {
        #region Members
        private MusicArtist _musician;
        private const string DELIMETER = ",";  //The comma delimeter, to follow the format LastName, FirstName
        #endregion

        #region Constructor
        /// <summary>
        /// default constructor
        /// </summary>
        public CompactDisc() { }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        public void SetArtistName(string firstName, string middleName, string lastName)
        {
            Musician = 
                new MusicArtist(string.Format("{0}{1} {2}{3} {4}", 
                lastName, 
                DELIMETER, 
                firstName,
                DELIMETER, 
                middleName));
        }



        /// <summary>
        /// Hnadles the Property changed event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case ("Musician"): Musicians.AddMusicArtist(new
                    MusicArtist(string.Format("{0}{1} {2} {3}", 
                    _musician.LastName, DELIMETER, 
                    _musician.FirstName,
                    _musician.MiddleName,
                    _musician.BirthDate,
                    _musician.DeathDate)));
                    break;
            }
        }
        #endregion

        #region Properties

        public MusicArtist Musician
        {
            get { return _musician; }
            private set
            {
                if (_musician != value)
                {
                    _musician = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ArtistName"));
                }
            }
        }

        public string AlbumName { get; private set; }

        public string RecordLabel { get; private set; }

        public string BarCodeId { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
