using System.Collections.Generic;

namespace FitnessHelper
{
    public class PremadeWorkout
    {
        public List<Workout> Workouts { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
    }
}