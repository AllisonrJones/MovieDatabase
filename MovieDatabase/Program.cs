using MovieDatabase;

List<Movie> watchList = new List<Movie>()
{
    new Movie("Shawshank Redemption", "drama"),
    new Movie("Zootopia", "animated"),
    new Movie("How to Train Your Dragon", "animated"),
    new Movie("Instant Family", "drama"),
    new Movie("La Misma Luna", "drama"),
    new Movie("Pilgrim's Progress", "animated"),
    new Movie("News of the World", "drama"),
    new Movie("Big Hero 6", "animated"),
    new Movie("White Noise", "drama"),
    new Movie("Spider Head", "sci-fi"),
    new Movie("MidSommar", "horror"),
    new Movie("Requiem for a Dream", "drama"),
    new Movie("Everything Everywhere All at Once", "drama")
    };
Console.WriteLine("Welcome to the Movie List Application!");
bool runProgram;
do
{
    Console.WriteLine($"There are {watchList.Count} movies to choose from. Please choose a catergory:");
    Console.WriteLine("Horror");
    Console.WriteLine("Drama");
    Console.WriteLine("Sci-Fi");
    Console.WriteLine("Animated");

    string movieNight = Console.ReadLine().ToLower().Trim();
    if (movieNight == "horror" || movieNight == "sci-fi" || movieNight == "drama" || movieNight == "animated")
    {
        Console.WriteLine($"In the category of {movieNight} we have:");
        foreach (Movie m in watchList.Where(m => m.Category.ToLower() == movieNight))
        {
            Console.WriteLine(m.GetDetail());
        }
        Console.WriteLine("Would you like to browse a different category? y/n");
        string answer = Console.ReadLine().ToLower().Trim();
        if (answer == "y")
        {
            runProgram = true;
        }
        else if(answer =="n")
        {
            runProgram = false;
            Console.WriteLine("Enjoy your movie night!");
            break;
        }
        else
        {
            Console.WriteLine("Press \"n\" to exit and \"y\" for other browsing options.");
            Console.ReadLine();
           
        }
    }
    else
    {
        runProgram = true;
        Console.WriteLine("That does not appear to be a category. Please check your spelling and try again");

    }
} while (true);

//int choice = int.Parse(Console.ReadLine());


//Console.WriteLine("What category would you like to view? Action, Adventure, Animated, Drama, Historical");
//string category = Console.ReadLine().ToLower().Trim();
//Console.WriteLine(String.Format("{0,-25} {1,-25}", "Title", "Category"));
//Console.WriteLine(String.Format("{0,-25} {1,-25}", "========", "========"));
//foreach (Movie m in watchList.Where(m => m.Category.ToLower() == category))
//{
//    Console.WriteLine(m.GetDetail());
//}