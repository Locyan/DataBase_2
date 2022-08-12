using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataModel
{
    public enum Genre 
    { 
        Rock, Pop, Jazz, HipHop, Metal
    }

    public class RecordDescription :DataElement
    {
        private string? album;
        public string Album 
        { 
            get => album ?? ""; 
            set 
            { 
                album = value;
                OnPropertyChanged();
            } 
        }

        private string? description;
        public string? Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged();
            }
        }

        private string? artist;
        public string? Artist
        {
            get => artist;
            set
            {
                artist = value;
                OnPropertyChanged();
            }
        }

        private Genre? genre;
        public Genre? Genre
        {
            get => genre;
            set
            {
                genre = value;
                OnPropertyChanged();
            }
        }

        

    }
}