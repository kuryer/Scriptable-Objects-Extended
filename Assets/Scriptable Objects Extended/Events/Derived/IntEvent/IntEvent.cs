using UnityEngine;

[CreateAssetMenu(menuName ="Scriptable Objects/Utilities/Events/Int Event")]
public class IntEvent : BaseVariableEvent<int>
{
    public void Add(int value)
    {
        Variable += value;
    }
}