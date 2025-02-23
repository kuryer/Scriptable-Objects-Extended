using UnityEngine;

[CreateAssetMenu(menuName ="Scriptable Objects/Utilities/Variables/Vector2")]
public class Vector2Variable : BaseVariable<Vector2>
{
    public override void SetToDefault()
    {
        Variable = new Vector2();
    }
}
