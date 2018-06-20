
namespace RougueLikeRPG

{
    /// <summary>interface responsável pelas coisas que podem ser consumidas </summary>
    public interface IFood: IHaveWeight
    {
        
        int HpIncrease { get; set; }
        int Id { get; set; }
    }
}
