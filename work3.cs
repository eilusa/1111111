using System;

public class GenericArray<T>
{
    private T[] array;

    public GenericArray(int size)
    {
        array = new T[size];
    }
    public T getItem(int index)
    {
        return array[index];
    }
    public void setItem(int index,T value)
    {
        array[index] = value;
    }
    public void forEach(Action<T> action)
    {
        Array.ForEach(array, m => Console.WriteLine(m));
        int sum=0;
        Array.ForEach(array, m => sum=sum+ (int)m);
        Console.WriteLine($"sum={sum}");

    }
}
