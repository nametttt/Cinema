//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cinema
{
    using System;
    using System.Collections.Generic;
    
    public partial class Film
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Film()
        {
            this.Session = new HashSet<Session>();
        }
    
        public int FilmID { get; set; }
        public string Title { get; set; }
        public string FilmDescription { get; set; }
        public int ReleaseDate { get; set; }
        public int CountryID { get; set; }
        public string Director { get; set; }
        public int GenreID { get; set; }
        public int RatingID { get; set; }
        public string Duration { get; set; }
        public byte[] Photo { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Rating Rating { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Session> Session { get; set; }

        public Film(string title, string filmDescription, int releaseDate, int countryID, string director, int genreID, int ratingID, string duration, byte[] photo)
        {
            Title = title;
            FilmDescription = filmDescription;
            ReleaseDate = releaseDate;
            CountryID = countryID;
            Director = director;
            GenreID = genreID;
            RatingID = ratingID;
            Duration = duration;
            Photo = photo;
        }
    }
}