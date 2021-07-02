using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();

            List<string> command = Console.ReadLine().Split(":").ToList();

            while (command[0] != "course start")
            {
                switch (command[0])
                {
                    case "Add":
                        AddingLessons(lessons, command);
                        break;
                    case "Insert":
                        InsertingLesson(lessons, command);
                        break;
                    case "Remove":
                        RemovingLessons(lessons, command);
                        break;
                    case "Swap":
                        SwappingLessons(lessons, command);
                        break;
                    case "Exercise":
                        AddingExercises(lessons, command);
                        break;
                }
                command = Console.ReadLine().Split(":").ToList();
            }
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }

        private static void AddingExercises(List<string> lessons, List<string> command)
        {
            string lessonName = command[1];
            string exerciseName = lessonName + "-Exercise";
            int lessonIndex = 0;
            bool ifLessonExists = false;
            bool ifExerciseExists = false;

            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessonName == lessons[i])
                {
                    ifLessonExists = true;
                    lessonIndex = i;
                }
                if (exerciseName == lessons[i])
                {
                    ifExerciseExists = true;
                }
            }
            if (ifLessonExists == true && ifExerciseExists == false)
            {
                lessons.Insert(lessonIndex + 1, exerciseName);
            }
            else if (ifLessonExists == false && ifExerciseExists == false)
            {
                lessons.Add(lessonName);
                lessons.Add(exerciseName);
            }
        }

        private static void SwappingLessons(List<string> lessons, List<string> command)
        {
            bool ifFirstLessonExists = false;
            bool ifSecondLessonExists = false;

            int firstLessonIndex = 0;
            int secondLessonIndex = 0;

            string firstLesson = command[1];
            string secondLesson = command[2];

            for (int i = 0; i < lessons.Count; i++)
            {
                if (firstLesson == lessons[i])
                {
                    ifFirstLessonExists = true;
                    firstLessonIndex = i;
                }
                if (secondLesson == lessons[i])
                {
                    ifSecondLessonExists = true;
                    secondLessonIndex = i;
                }
            }
            if (ifFirstLessonExists == true && ifSecondLessonExists == true)
            {
                string temp = lessons[firstLessonIndex];
                lessons[firstLessonIndex] = lessons[secondLessonIndex];
                lessons[secondLessonIndex] = temp;
                SwappingExercises(lessons, ref firstLessonIndex, ref secondLessonIndex, firstLesson, secondLesson);
            }
        }

        private static void SwappingExercises(List<string> lessons, ref int firstLessonIndex, ref int secondLessonIndex, string firstLesson, string secondLesson)
        {
            for (int i = 0; i < lessons.Count; i++)
            {
                if (firstLesson + "-Exercise" == lessons[i])
                {
                    for (int j = 0; j < lessons.Count; j++)
                    {
                        if (firstLesson == lessons[j])
                        {
                            firstLessonIndex = j;
                            break;
                        }
                    }
                    lessons.Insert(firstLessonIndex + 1, lessons[i]);
                    lessons.RemoveAt(i + 1);
                }
                if (secondLesson + "-Exercise" == lessons[i])
                {
                    for (int j = 0; j < lessons.Count; j++)
                    {
                        if (secondLesson == lessons[j])
                        {
                            secondLessonIndex = j;
                            break;
                        }
                    }
                    lessons.Insert(secondLessonIndex + 1, lessons[i]);
                    lessons.RemoveAt(i + 1);
                }
            }
        }

        private static void RemovingLessons(List<string> lessons, List<string> command)
        {
            bool ifExists = false;
            bool ifExerciseExists = false;
            string lessonName = command[1];
            string lessonExercise = lessons + "-Exercise";
            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessonName == lessons[i])
                {
                    ifExists = true;

                }
                if (lessonExercise == lessons[i])
                {
                    ifExerciseExists = true;
                }
            }
            if (ifExists == true)
            {
                lessons.Remove(lessonName);
                if (ifExerciseExists == true)
                {
                    lessons.Remove(lessonExercise);
                }
            }
        }

        private static void InsertingLesson(List<string> lessons, List<string> command)
        {
            string lessonName = command[1];
            bool ifExists = false;
            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessonName == lessons[i])
                {
                    ifExists = true;
                    break;
                }
            }
            if (ifExists == false)
            {
                lessons.Insert(int.Parse(command[2]),lessonName);
            }
        }

        private static void AddingLessons(List<string> lessons, List<string> command)
        {
            string lessonName = command[1];
            bool ifExists = false;
            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessonName == lessons[i])
                {
                    ifExists = true;
                    break;
                }
            }
            if (ifExists == false)
            {
                lessons.Add(lessonName);
            }
        }
    }
}
