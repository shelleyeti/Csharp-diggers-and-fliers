namespace diggers_and_fliers
{
    public interface IFlier
    {
        string Wing { get; set; }

        void Fly(string Wing);
        void Eat();
    }
}