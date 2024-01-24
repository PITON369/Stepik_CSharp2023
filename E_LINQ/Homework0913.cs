using System;
using System.Collections.Generic;

namespace E_LINQ
{
    public class Homework0913
    {
        /*
        The computer asks questions or gives some statements to a person, and the person answers yes/no, 
        whether he believes or does not believe the statement. The computer takes questions from the file, 
        the correct answers and explanations for the answers too. You can write your data to a file.
        The number of errors is limited and by default is 2. The computer asks questions from the file and 
        if the person answered all the questions without making more than the maximum allowed number of 
        errors, then the player wins, otherwise he loses.
        If the player makes a mistake when answering, the computer displays an explanation of the answer.
        Implement the dialogue in the form that you consider most acceptable.
         */
        public class Game
        {
            private readonly List<Question> questions;
            private readonly int allowedMistakes;
            private int counter;
            private int mistakes;

            public event EventHandler<GameResultEventArgs> EndOfGame;

            public Game(string filePath, int allowedMistakes = 2)
            {
                if (filePath == null)
                    throw new ArgumentNullException("filePath");

                if (filePath == "")
                    throw new ArgumentException("filePath should not be empty");

                if (allowedMistakes < 2)
                    throw new ArgumentException("allowedMistakes should be >= 2");

                List<Question> questions = File.ReadAllLines(filePath)
                                                      .Select(x =>
                                                      {
                                                          string[] parts = x.Split(';');
                                                          string text = parts[0];
                                                          bool correctAnswer = parts[1] == "Yes";
                                                          string explanation = parts[2];

                                                          return new Question(text, correctAnswer, explanation);
                                                      }).ToList();

                this.questions = questions;
                this.allowedMistakes = allowedMistakes;
                GameStatus = GameStatus.GameInProgress;
            }

            public GameStatus GameStatus { get; private set; }

            public Question GetNextQuestion()
            {
                return questions[counter];
            }

            public void GiveAnswer(bool answer)
            {
                if (questions[counter].CorrectAnswer != answer)
                {
                    mistakes++;
                }

                if (counter == questions.Count - 1 || mistakes > allowedMistakes)
                {
                    GameStatus = GameStatus.GameIsOver;
                    if (EndOfGame != null)
                        EndOfGame(this, new GameResultEventArgs(counter, mistakes, mistakes <= allowedMistakes));
                }

                counter++;
            }
        }

        public event EventHandler<GameResultEventArgs> EndOfGame;

        public enum GameStatus
        {
            GameIsOver,
            GameInProgress
        }

        public class Question
        {
            public Question(string text, bool correctAnswer, string explanation)
            {
                Text = text;
                CorrectAnswer = correctAnswer;
                Explanation = explanation;
            }

            public string Text { get; }
            public bool CorrectAnswer { get; }
            public string Explanation { get; }
        }

        public class GameResultEventArgs : EventArgs
        {
            public GameResultEventArgs(int questionsPassed, int mistakesMade, bool isWin)
            {
                QuestionsPassed = questionsPassed;
                MistakesMade = mistakesMade;
                IsWin = isWin;
            }

            public int QuestionsPassed { get; }
            public int MistakesMade { get; }
            public bool IsWin { get; }
        }

        public void Start()
        {
            var game = new Game("Questions.csv");
            game.EndOfGame += (sender, e) =>
            {
                Console.WriteLine($"Questions asked:{e.QuestionsPassed}. Mistakes made:{e.MistakesMade}");
                Console.WriteLine(e.IsWin ? "You won!" : "You lost!");
            };

            while (game.GameStatus == GameStatus.GameInProgress)
            {
                Question q = game.GetNextQuestion();
                Console.WriteLine("Dou you believe in the next statement or question? Enter 'y' or 'n'");
                Console.WriteLine(q.Text);

                string answer = Console.ReadLine();
                bool boolAnswer = answer == "y";

                if (q.CorrectAnswer == boolAnswer)
                {
                    Console.WriteLine("Good job. You're right!");
                }
                else
                {
                    Console.WriteLine("Ooops, actually you're mistaken. Here is the commentary:");
                    Console.WriteLine(q.Explanation);
                }

                game.GiveAnswer(boolAnswer);
            }

            Console.ReadLine();
        }
    }
}