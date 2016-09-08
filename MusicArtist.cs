using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryControl
{
    public class MusicArtist
    {
        #region Members
        private string _firstName;
        private string _lastName;
        private string _middleName;
        private DateTime _birthDate;
        private DateTime _deathDate;
        private readonly char[] DELIMETERS = new char[] { ',', ' ' };  //The comma delimeter, to follow the format LastName, FirstName
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor w/o DeathDate (default)
        /// </summary>
        /// <param name="name">Sets the Name property</param>
        /// <param name="birthDate">Sets the BirthDate property.</param>
        public MusicArtist(string name, DateTime birthDate)
        {
            string[] nameParts = name.Split(DELIMETERS, StringSplitOptions.RemoveEmptyEntries);
            LastName = nameParts[0];
            FirstName = nameParts[1];
            if (nameParts.Length >= 3)
            {
                MiddleName = nameParts[2];
            }
            else
            {
                MiddleName = string.Empty;
            }
            BirthDate = birthDate;
        }

        /// <summary>
        /// Constructor w/o DeathDate (default)
        /// </summary>
        /// <param name="name">Sets the Name property</param>
        public MusicArtist(string name)
        {
            string[] nameParts = name.Split(DELIMETERS, StringSplitOptions.RemoveEmptyEntries);
            LastName = nameParts[0];
            FirstName = nameParts[1];
            if (nameParts.Length >= 3)
            {
                MiddleName = nameParts[2];
            }
            else
            {
                MiddleName = string.Empty;
            }
        }

        /// <summary>
        /// constructor with DeathDate
        /// </summary>
        /// <param name="name">Name of the artist.</param>
        /// <param name="birthDate">Artist's DOB.</param>
        /// <param name="deathDate">Artists Date of Passing.</param>
        public MusicArtist(string name, DateTime birthDate, DateTime deathDate)
        {
            string[] nameParts = name.Split(DELIMETERS, StringSplitOptions.RemoveEmptyEntries);
            LastName = nameParts[0];
            FirstName = nameParts[1];
            if (nameParts.Length >= 3)
            {
                MiddleName = nameParts[2];
            }
            else
            {
                MiddleName = string.Empty;
            }
            BirthDate = birthDate;
            DeathDate = deathDate;
        }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Properties

        public string FirstName
        {
            get { return _firstName; }
            private set
            {
                if (_firstName != value)
                    _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string MiddleName
        {
            get { return _middleName; }
            private set
            {
                if (_middleName != value)
                    _middleName = value;
                OnPropertyChanged("MiddleName");
            }
        }

        public string LastName
        {
            get { return _lastName; }
            private set
            {
                if (_lastName != value)
                    _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
            private set
            {
                if (_birthDate != value)
                    _birthDate = value;
                OnPropertyChanged("BirthDate");
            }
        }

        public DateTime DeathDate
        {
            get { return _deathDate; }
            private set
            {
                if (_deathDate != value)
                    _deathDate = value;
                OnPropertyChanged("DeathDate");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
