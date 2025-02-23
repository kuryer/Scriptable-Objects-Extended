using UnityEngine;

public abstract class BaseVariable<T> : ScriptableObject
{
    public T Variable;

    [SerializeField] T DefaultValue;

    public virtual void SetToDefault()
    {
        Variable = DefaultValue;
    }
}
