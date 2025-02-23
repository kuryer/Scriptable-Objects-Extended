using UnityEngine;


[CreateAssetMenu(menuName = "Scriptable Objects/Utilities/Variables/Vector2Int")]
public class Vector2IntVariable : BaseVariable<Vector2Int>
{
    public override void SetToDefault()
    {
        Variable = new Vector2Int();
    }
}
