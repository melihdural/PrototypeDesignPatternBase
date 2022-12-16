namespace PrototypeDesignPattern;

public interface IPrototype<T>
{
    public T? Clone();
}