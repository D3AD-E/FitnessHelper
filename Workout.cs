using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace FitnessHelper
{
    public class Workout: IEquatable<Workout>
    {
        public string Name { get; set; }
        public int Seconds { get; set; }
        public ImageSource Preview { get; set; }
        public bool Completed { get; set; }

        public bool Equals(Workout other)
        {
            return this.Completed == other.Completed;
        }
        public Workout()
        {
            Completed = false;
        }
    }
}
