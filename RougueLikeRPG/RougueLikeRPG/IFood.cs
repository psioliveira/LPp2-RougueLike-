﻿
namespace RougueLikeRPG
{
    public interface IFood: IHaveWeight
    {
        
        int HpIncrease { get; set; }
        int Id { get; set; }
    }
}
