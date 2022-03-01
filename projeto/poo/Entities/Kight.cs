namespace poo.Entities
{
    public class Kight : Hero
    {
        public Kight( string Name, int Level, string Herotype)
        {
            this.Name = Name;
            this.level = Level;
            this.Herotype = Herotype;
        }

        public Kight(){

        }

         public override string Attack()
        {
            return this.Name + " " + "Lançou a magia implacável! SHAZAM";
        }
    }
}