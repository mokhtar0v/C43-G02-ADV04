using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4_Advanced
{
    class MovieEqualityComparer : IEqualityComparer<Movie>
    {
        public bool Equals(Movie? x, Movie? y)
        {
            return x?.Price.Equals(y?.Price)??(y is null ? true : false);
        }

        public int GetHashCode([DisallowNull] Movie obj)
        {
            return obj.Price.GetHashCode();
        }
    }

    internal class Movie : IEquatable<Movie>
    {
        public Movie(int iD, string title, decimal price)
        {
            ID = iD;
            Title = title;
            Price = price;
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return $"ID = {ID}, Title : {Title}, Price = {Price}";  
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(ID, Title, Price);
        }
        //public override bool Equals(object? obj)
        //{
        //    Movie? other = obj as Movie;
        //    return this.ID.Equals(other?.ID) && this.Title.Equals(other?.Title) && this.Price.Equals(other?.Price);
        //}

        public bool Equals(Movie? other)
        {
            return this.ID.Equals(other?.ID) && this.Title.Equals(other?.Title) && this.Price.Equals(other?.Price);
        }
    }
}
