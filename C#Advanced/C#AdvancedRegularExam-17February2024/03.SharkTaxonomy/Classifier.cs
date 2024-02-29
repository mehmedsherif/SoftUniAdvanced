using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharkTaxonomy
{
    public class Classifier
    {
        public Classifier(int capacity)
        {
            Capacity = capacity;
            Species = new List<Shark>();
        }

        public int Capacity { get; set; }
        public List<Shark> Species { get; set; }

        public int GetCount=> Species.Count; 

        public void AddShark(Shark shark)
        {
            bool sharkExists = Species.Any(k => k.Kind.Equals(shark.Kind));

            if (Species.Count < Capacity && !sharkExists)
            {
                Species.Add(shark);
            }
        }

        public bool RemoveShark(string kind)
        {
            Shark sharkToRemove = Species.FirstOrDefault(k => k.Kind.Equals(kind));
            if (sharkToRemove != null)
            {
                Species.Remove(sharkToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetLargestShark()
        {
            Shark largestShark = Species.OrderByDescending(l => l.Length).First();
            return largestShark.ToString();
        }

        public float GetAverageLength()
        {
            float totalLength = Species.Sum(l => l.Length);
            return totalLength / Species.Count;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetCount} sharks classified:");

            foreach (var shark in Species)
            {
                sb.AppendLine(shark.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}