using System;


namespace RougueLikeRPG
{
    class Weapon : IHaveWeight, IAmItem
    {
        public string name = "";
        public float Weight { get; set; } = 0;
        public int Id { get; set; } = 0;
        public int Damage { get; set; } = 0;
        public bool broken = false;
        public float durability = 0f;
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
                    name = "Club";
                    Damage = 8;
                    Weight = 34;
                    durability = 0.3f;
                    break;
                case 1:

                    name = "Dagger";
                    Damage = 15;
                    Weight = 12;
                    durability = 0.7f;

                    break;

                case 2:

                    name = "Sword";
                    Damage = 20;
                    Weight = 36;
                    durability = 0.5f;
                    break;

                case 3:

                    name = "Katana";
                    Damage = 40;
                    Weight = 28;
                    durability = 0.8f;
                    break;

                default:
                    break;

            }
        }


    }
}
