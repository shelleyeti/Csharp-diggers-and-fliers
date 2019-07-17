namespace diggers_and_fliers
{
    public interface ISwimmer
    {
        int Fins { get; set; }

        void Swim(int Fins);
        void Live();
    }
}