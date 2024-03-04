namespace PomodoroTimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pomodoro Timer!");

            while (true)
            {
                Console.WriteLine("Press Enter to start a Pomodoro session.");
                Console.ReadLine();

                StartPomodoro();
                Console.WriteLine("Pomodoro session completed!");

                Console.WriteLine("Take a short break.");
                Thread.Sleep(TimeSpan.FromMinutes(5)); // Short break, 5 minutes

                Console.WriteLine("Short break completed!");

                Console.WriteLine("Press Enter to start the next Pomodoro session or type 'exit' to quit.");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                    break;
            }

            Console.WriteLine("Goodbye!");
        }

        static void StartPomodoro()
        {
            int pomodoroDuration = 25; // Pomodoro duration in minutes
            TimeSpan duration = TimeSpan.FromMinutes(pomodoroDuration);
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.Add(duration);

            Console.WriteLine($"Pomodoro session started at {startTime.ToString("HH:mm")}.");
            Console.WriteLine($"Pomodoro session will end at {endTime.ToString("HH:mm")}.");

            while (DateTime.Now < endTime)
            {
                TimeSpan remainingTime = endTime - DateTime.Now;
                Console.Write($"\rTime remaining: {remainingTime.ToString(@"mm\:ss")}");
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
            Console.WriteLine();
        }
    }
    
}
