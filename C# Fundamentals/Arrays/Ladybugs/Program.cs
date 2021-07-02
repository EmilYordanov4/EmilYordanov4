using System;
using System.Linq;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int field = int.Parse(Console.ReadLine());
            int[] fieldWithLadybugs = new int[field];

            int[] ladybugsStartingPlacement = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < field; i++)
            {
                if (i > ladybugsStartingPlacement.Length - 1)
                {
                    break;
                }
                else
                {
                    int number = ladybugsStartingPlacement[i];
                    fieldWithLadybugs[number] = 1;
                }
            }

            string input = Console.ReadLine();

            int ladybugMoving = 0;
            string movementDirection = string.Empty;
            int placesChanges = 0;
            int startingSlot = 0;
            int[] lengthOfArray = new int[fieldWithLadybugs.Length];

            while (input != "end")
            {
                string[] commands = input.Split().ToArray();

                for (int i = 0; i < commands.Length; i++)
                {
                    if (i == 0)
                    {
                        ladybugMoving = int.Parse(commands[i]);
                        startingSlot = ladybugMoving;
                    }
                    if (i == 1)
                    {
                        movementDirection = commands[i];
                    }
                    if (i == 2)
                    {
                        placesChanges = int.Parse(commands[i]);
                    }
                }
                //
                if (fieldWithLadybugs[ladybugMoving] == 1)
                {
                    if (movementDirection == "right")
                    {
                        for (int i = 0; i <= fieldWithLadybugs.Length; i++)
                        {
                            if (lengthOfArray.Length + ladybugMoving > fieldWithLadybugs.Length)
                            {
                                break;
                            }
                            if (fieldWithLadybugs[ladybugMoving] == 1)
                            {
                                placesChanges++;
                                ladybugMoving++;
                                continue;
                            }
                            else
                            {
                                fieldWithLadybugs[startingSlot] = 0;
                                fieldWithLadybugs[ladybugMoving] = 1;
                            }
                            
                        }
                    }
                    else if (movementDirection == "left")
                    {

                    }
                }
                else
                {
                    continue;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", fieldWithLadybugs));
        }
    }
}
