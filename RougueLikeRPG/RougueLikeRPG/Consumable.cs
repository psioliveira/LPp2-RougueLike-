using System;
using System.Collections.Generic;

namespace RougueLikeRPG
{
    public class Consumable : IFood, IAmItem
    {
        /// <summary>
        /// Classe que representa alimentos ou itens de cura
        /// </summary>
        
        string Name { get; set; } = "";
        public int HpIncrease { get; set; } = 0;
        public int Id { get; set; } = 0;
        public float Weight { get; set; } = 0;

        public Consumable(int Id)
        {
            this.Id = Id;
            FoodName(Id);
        }

        void FoodName(int id)
        {
            switch (id)
            {
                case 1:
                    Name = "Cherry";
                    HpIncrease = 5;
                    Weight = 1;
                    break;

                case 2:
                    Name = "Tomato";
                    HpIncrease = 9;
                    Weight = 2;
                    break;
                    
                case 3:
                    Name = "Bread";
                    HpIncrease = 10;
                    Weight = 4;
                    break;

                case 4:
                    Name = "Cheese";
                    HpIncrease = 14;
                    Weight = 3;
                    break;

                case 5:
                    Name = "Fish";
                    HpIncrease = 20;
                    Weight = 8;
                    break;

                case 6:
                    Name = "Meat";
                    HpIncrease = 15;
                    Weight = 10;
                    break;

                case 7:
                    Name = "Health Potion";
                    HpIncrease = 50;
                    Weight = 13;
                    break;

                case 8:
                    Name = "Great Health Potion";
                    HpIncrease = 80;
                    Weight = 15;
                    break;


                default:
                    break;
            }
        }

    }
}
