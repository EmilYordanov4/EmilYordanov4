using System;
using System.Linq;

namespace TrainingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            EntireTraining entireTrainingProgram = new EntireTraining();

            while (input != "kurvi sbogom")
            {
                string[] info = input.Split(",").ToArray();

                if (info[0] == "Upper Body")
                {
                    UpperBody newExercise = new UpperBody();
                    newExercise.Exercise = info[1];
                    newExercise.Sets = info[2];
                    newExercise.Reps = info[3];
                    newExercise.Kgs = info[4];
                    entireTrainingProgram.allUpperBoddyExercises.Add(newExercise);
                }
                else if (info[0] == "Lower Body")
                {
                    LowerBody newExercise = new LowerBody();
                    newExercise.Exercise = info[1];
                    newExercise.Sets = info[2];
                    newExercise.Reps = info[3];
                    newExercise.Kgs = info[4];
                    entireTrainingProgram.allLowerBodyExercises.Add(newExercise);
                }

                input = Console.ReadLine();
            }

            if (entireTrainingProgram.allLowerBodyExercises.Count > 0)
            {
                foreach (LowerBody exercise in entireTrainingProgram.allLowerBodyExercises)
                {
                    Console.WriteLine($"{exercise.Exercise}{exercise.Sets}sets{exercise.Reps}reps each set with{exercise.Kgs}kgs");
                }
            }
            if (entireTrainingProgram.allUpperBoddyExercises.Count > 0)
            {
                foreach (UpperBody exercise in entireTrainingProgram.allUpperBoddyExercises)
                {
                    Console.WriteLine($"{exercise.Exercise}{exercise.Sets}sets{exercise.Reps}reps each set with{exercise.Kgs}kgs");
                }
            }
        }
    }
}
// L/U Body , name , set , rep , kg