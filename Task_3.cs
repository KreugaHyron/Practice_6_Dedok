using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_6_Dedok
{
    public abstract class SeaCreature
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public SeaCreature(string name, string species)
        {
            Name = name;
            Species = species;
        }
        public override string ToString()
        {
            return $"{Name} ({Species})";
        }
    }
    public class Fish : SeaCreature
    {
        public Fish(string name) : base(name, "Fish") { }
    }
    public class Jellyfish : SeaCreature
    {
        public Jellyfish(string name) : base(name, "Jellyfish") { }
    }
    public class Turtle : SeaCreature
    {
        public Turtle(string name) : base(name, "Turtle") { }
    }
    public class Oceanarium : IEnumerable<SeaCreature>
    {
        private List<SeaCreature> seaCreatures = new List<SeaCreature>();
        public void AddSeaCreature(SeaCreature creature)
        {
            seaCreatures.Add(creature);
        }
        public IEnumerator<SeaCreature> GetEnumerator()
        {
            foreach (var creature in seaCreatures)
            {
                yield return creature;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
