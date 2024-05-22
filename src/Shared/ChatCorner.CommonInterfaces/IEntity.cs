namespace ChatCorner.CommonInterfaces;

public interface IEntity<T>
{
    T ID { get; set; }
}