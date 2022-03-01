namespace poo.Entities
{
    public abstract class Hero
    {
        public Hero( string Name, int Level, string Herotype)
        {
            this.Name = Name;
            this.level = Level;
            this.Herotype = Herotype;
        }

        public Hero(){

        }

        public string Name;

        public int level;

        public string Herotype;

        public override string ToString()
        {
            return this.Name + " " + this.level + " " + this.Herotype;
        }

        public virtual string Attack()
        {
            return this.Name +" " + "Atacou com a sua espingarda!POW";
        }
    }
}