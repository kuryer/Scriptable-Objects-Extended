using UnityEngine;

[CreateAssetMenu(menuName ="Scriptable Objects/Utilities/Variables/Int")]
public class IntVariable : BaseVariable<int>
{
    public void Inrease(int value)
    {
        Variable += value;
    }
}
