namespace CdbCalculator.Application.interfaces
{
    public interface IServiceResult<T>
    {
        bool Status { get; set; }
        IList<string> Mensagens { get; set; }
    }
}
