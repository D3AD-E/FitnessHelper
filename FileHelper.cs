using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace FitnessHelper
{
    internal class FileHelper
    {
        public enum ReadMode
        {
            User,
            Premade
        }

        private string path = "./Workouts.xml";

        public void Write<T>(T workouts)
        {
            var doc = new XDocument();
            using (var writer = doc.CreateWriter())
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, workouts);
            }
            doc.Save(path);
        }

        public List<PremadeWorkout> Read(ReadMode rm)
        {
            var serializer = new XmlSerializer(typeof(List<PremadeWorkout>));
            using (var fs = new FileStream(path, FileMode.Open))
            {
                List<PremadeWorkout> workouts = (List<PremadeWorkout>)serializer.Deserialize(fs);
                return workouts;
            }

            /*
            var serializer = new XmlSerializer(typeof(List<Workout>));
            using (var fs = new FileStream(path, FileMode.Open))
            {
                List<Workout> workouts = (List<Workout>)serializer.Deserialize(fs);
                return workouts;
            }*/
        }
    }
}