using System;

namespace MultiplicationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int correctAnswers = 0;

            for (int i = 0; i < 10; i++)
            {
                int num1 = random.Next(1, 11);
                int num2 = random.Next(1, 11);
                int correctResult = num1 * num2;

                Console.WriteLine($"Question {i + 1}: What is {num1} x {num2}?");

                int userAnswer = GetValidAnswer();

                if (userAnswer == correctResult)
                {
                    Console.WriteLine("Correct!");
                    correctAnswers++;
                }
                else
                {
                    Console.WriteLine($"Wrong. The correct answer is {correctResult}.");
                }
            }

            Console.WriteLine($"Well done! You got {correctAnswers} out of 10 correct.");
            GiveSupportiveMessage(correctAnswers);
        }

        static int GetValidAnswer()
        {
            int userAnswer;
            while (true)
            {
                Console.Write("Your answer: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out userAnswer) && userAnswer >= 1 && userAnswer <= 100)
                {
                    return userAnswer;
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer between 1 and 100.");
                }
            }
        }

        static void GiveSupportiveMessage(int correctAnswers)
        {
            if (correctAnswers == 10)
            {
                Console.WriteLine("Excellent work! You got everything correct!");
            }
            else if (correctAnswers >= 7)
            {
                Console.WriteLine("Great job! Keep practicing to get even better!");
            }
            else if (correctAnswers >= 4)
            {
                Console.WriteLine("Good effort! Try to review the questions you missed.");
            }
            else
            {
                Console.WriteLine("Don't worry, keep practicing and you'll improve!");
            }
        }
    }
}