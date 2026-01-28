public class Movie
{
    public string Title {get; set;}
    public string Artist {get; set;}
    public string Genre {get; set;}
    public int Ratings {get; set;}
}

public class Program
{
    public static List<Movie> MovieList=new List<Movie>();
    public void AddMovie(string MovieDetails)
    {
        string []detail = MovieDetails.Split(',');
        Movie nMovie = new Movie
        {
            Title=detail[0],
            Artist=detail[1],
            Genre=detail[2],
            Ratings=int.Parse(detail[3])
        };
        MovieList.Add(nMovie);
    }
    public List<Movie> ViewMoviesByGenre(string genre)
    {
        List<Movie>ans=new List<Movie>();
        foreach(var move in MovieList)
        {
            if (move.Genre == genre)
            {
                ans.Add(move);
            }
        }
        return ans;
    }
    public List<Movie>ViewMovieRating()
    {
        var ans = MovieList.OrderByDescending(x=>x.Ratings);
        return ans.ToList();
    }
    public static void Main(string []args)
    {
        Program pr = new Program();
        pr.AddMovie("How to lose a guy in 10 days, Matthew,Romance,7");
        pr.AddMovie("Interstellar,Christopher Nolan,Sci-Fi,8");
        pr.AddMovie("Eternal Sunshine of the spotless Mind, Jim Carrey,Romance,8");
        pr.AddMovie("Me Before you , Emilia Clarke,Romance,7");

        
        var RomanceMovies = pr.ViewMoviesByGenre("Romance");
        Console.WriteLine("Romantic Movies: ");
        foreach (var movie in RomanceMovies)
        {
            Console.WriteLine($"{movie.Title} - {movie.Ratings}");
        }
        var  RatingSort = pr.ViewMovieRating();
        Console.WriteLine("Rating Wise: ");
        foreach (var movie in RatingSort)
        {
             Console.WriteLine($"{movie.Title} - {movie.Ratings}");
        }
    }
}