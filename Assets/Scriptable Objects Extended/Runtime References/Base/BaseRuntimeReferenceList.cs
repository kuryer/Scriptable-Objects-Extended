using System.Collections.Generic;
using UnityEngine;

public abstract class BaseRuntimeReferenceList<T> : ScriptableObject
{
    public List<T> List;

    public void Add(T item)
    {
        List.Add(item);
    }

    public void Remove(T item)
    {
        if(List.Contains(item))
            List.Remove(item);
    }

    public void ResetList()
    {
        List.Clear();
    }
}