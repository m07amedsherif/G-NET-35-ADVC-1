namespace ConsoleApp2
{
    public interface IPrintable
    {
        void Print();
    }

    public interface IBookable
    {
        bool Book();
        bool Cancel();
        bool IsBooked { get; }
    }
}