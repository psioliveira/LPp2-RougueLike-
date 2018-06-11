namespace RougueLike
{
    interface IHaveWeight
    {
        float weight { get; set; }
        int id { get; set; }
        void Drop();
        void Take();
    }
}
