namespace diggers_and_fliers
{
    public interface IWalker
    {
        int Feet { get; set; }
        void Walk(int Feet);
        void Run(int Feet);
    }
}