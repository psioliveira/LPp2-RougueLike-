

namespace RougueLikeRPG
{
    /// <summary>interface responsável pelas coisas que são items </summary>
    public interface IAmItem : IHaveWeight
    {
        string Name { get; set; }
    }
}
