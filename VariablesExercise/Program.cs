namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string memberName = "Cheryl B.";
            int numberOfPuppiesRaised = 3;
            char sexPreference = 'F';
            bool readyForNextPuppy = true;
            double vetVisits = 5;
            decimal crossBread = 62.6m;

            Console.WriteLine($"{memberName} has raised {numberOfPuppiesRaised} dogs for The Seeing Eye.  Her family" +
                $"prefers to raise {sexPreference} dogs.  They are ready for their next puppy, {readyForNextPuppy}!" +
                $"During the first four months they will visit the vet {vetVisits} times. This is a decimal{crossBread}");

            Console.WriteLine("Is this all true Cheryl?");
            Console.ReadLine();

        }
    }
}
