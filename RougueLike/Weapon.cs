using System;


namespace RougueLike
{
    class Weapon : IHaveWeight
    {
        public string name = "";
        public float Weight { get; set; } = 0;
        public int Id { get; set; } = 0;
        public int Damage { get; set; } = 0;
        public bool broken = false;

        public Weapon(int Id)
        {
            this.Id = Id;
            Dmg(Id);
        }

        public void Dmg(int Id)
        {
            switch (Id)
            {
                case 0:
                    name = "Sword";
                    Damage = 20;
                    Weight = 36;
                    break;

                case 1:
                    name = "Katana";
                    Damage = 30;
                    Weight = 28;
                    break;

                case 2:
                    name = "Dagger";
                    Damage = 15;
                    Weight = 12;
                    break;

                case 3:
                    name = "Staff";
                    Damage = 10;
                    Weight = 20;
                    break;

                case 4:
                    name = "Club";
                    Damage = 8;
                    Weight = 34;
                    break;

                case 5:
                    name = "Excalibur";
                    Damage = 60;
                    Weight = 45;
                    break;

                case 6:
                    name = "Broad Sword";
                    Damage = 38;
                    Weight = 40;
                    break;

                default:
                    break;

            }
        }


    }
}
