using System.Collections.Generic;
using UnityEngine;

public abstract class BaseVariableEvent<T> : ScriptableObject
{
    [SerializeField] private T defaultVariable; 
    private T variable;
    public T Variable { get { return variable; } set { variable = value; RaiseEvent(); } }
    List<VariableEventListener<T>> listeners = new List<VariableEventListener<T>>();

    public void Initialize()
    {
        variable = defaultVariable;
    }

    public void ChangeVariable(T value)
    {
        Variable = value;
    }

    public void Subscribe(VariableEventListener<T> eventListener)
    {
        listeners.Add(eventListener);
    } 

    public void Unsubscribe(VariableEventListener<T> eventListener)
    {
        listeners.Remove(eventListener);
    }

    protected void RaiseEvent()
    {
        foreach (var listener in listeners)
            listener.Raise(Variable);
    }
}
