namespace poo.Entities
{
    public class Wizard : Hero
    {

        public Wizard( string Name, int Level, string Herotype)
        {
            this.Name = Name;
            this.level = Level;
            this.Herotype = Herotype;
        }

        public Wizard(){

        }
         public override string Attack()
        {
            return this.Name + " " + "Lançou a magia implacável! SHAZAM";
        }
         public  string Attack(int Bonus)
        {
            if( Bonus > 6){
                return this.Name + " " + "Lançou a magia implacável com bonus de ataque! SHAZAM com bonus de "+ " " + Bonus;
            }else{
                return this.Name + " " + " Lançou uma magia chinfrinha que fez cocégas!com bonus de "+ " " + Bonus;
            }
            
        }
    }
}