using System;

namespace Fiver.Design.HonestMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void HaveToBeReadyForNull()
        {
            var repo = new MovieRepository();

            var movie = repo.FindById(5);
            
            // use movie

            // exception on null
        }

        static void HaveToBeReadForException()
        {
            var service = new MovieService();

            var b = service.UploadDocument("", "");

            // what does true/false represent - have to look at implementation details
            // may throw exception at runtime - have to look at implementation details
        }

        static void HonestSignature1()
        {
            var repo = new MovieRepositoryHonest();

            var result = repo.FindById(5);

            if (result.IsSuccess)
                Console.WriteLine("Found");
            else
                Console.WriteLine($"Not Found: {result.FailureValue.Message}");
        }

        static void HonestSignature2()
        {
            var repo = new MovieRepositoryHonest();

            var result = repo.FindById(5);

            result.Do(
                movie => Console.WriteLine("Found"),
                error => Console.WriteLine($"Not Found: {error.Message}"));
        }
    
        static void HonestSignature3()
        {
            var service = new MovieServiceHonest();

            var file = new UploadFile("how-to", "pdf");
            
            var result = service.UploadDocument(file);

            if (result.HasUploaded)
                Console.WriteLine("Found");
            else
                Console.WriteLine($"Failure: {result.FailureMessage}");
        }
    }
}
