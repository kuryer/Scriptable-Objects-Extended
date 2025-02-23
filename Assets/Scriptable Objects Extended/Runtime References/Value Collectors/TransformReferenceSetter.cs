using UnityEngine;

public class TransformReferenceSetter : MonoBehaviour
{
    [SerializeField] TransformReference reference;

    private void Awake()
    {
        if(enabled)
            reference.Set(transform);
    }

    private void OnEnable()
    {
        reference.Set(transform);
    }

    private void OnDisable()
    {
        reference.SetNull();
    }
}
