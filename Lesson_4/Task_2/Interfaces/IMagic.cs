namespace Open_Closed.Interfaces
{
    public interface IMagic
    {
        string MagicType { get; }

        void CountYourMagic() => Console.WriteLine($"Your magic is {MagicType}.");
    }
}
