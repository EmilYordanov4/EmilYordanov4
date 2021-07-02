using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingProgram
{
    class EntireTraining
    {
        public List<UpperBody> allUpperBoddyExercises { get; }
        public List<LowerBody> allLowerBodyExercises { get; }

        public EntireTraining()
        {
            allLowerBodyExercises = new List<LowerBody>();
            allUpperBoddyExercises = new List<UpperBody>();
        }
    }
}
