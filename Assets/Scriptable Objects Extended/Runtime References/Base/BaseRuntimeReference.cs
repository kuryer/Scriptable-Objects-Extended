using UnityEngine;

public abstract class BaseRuntimeReference<T> : ScriptableObject where T : class
{
    private T Item;

    public void Set(T item)
    {
        Item = item;
    }

    public T Get()
    {
        return Item;
    }

    public void SetNull()
    {
        Item = null;
    }
}

