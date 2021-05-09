namespace MyVinted.Core.Application.Builders.Interfaces
{
    public interface IBuilder<T> where T : class, new()
    {
        T Build();
    }
}