namespace Fiver.Design.HonestMethods
{
    public class MovieRepository
    {
        public Movie FindById(int id)
        {
            // if id not found
                // return null;

            return new Movie(); // id found
        }
    }

    public class MovieRepositoryHonest
    {
        public Result<Movie, Error> FindById(int id)
        {
            // if id found
                // return Result<Movie, Error>.Ok(new Movie());

            return Result<Movie, Error>.Fail(Error.Create("id not found"));
        }
    }
}
