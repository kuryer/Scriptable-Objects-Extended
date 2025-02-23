using UnityEngine;
using UnityEngine.Events;

public abstract class VariableEventListener<T> : MonoBehaviour
{
    [SerializeField] BaseVariableEvent<T> varEvent;
    [SerializeField] UnityEvent<T> response;

    private void OnEnable()
    {
        varEvent.Subscribe(this);
    }

    private void OnDisable()
    {
        varEvent.Unsubscribe(this);
    }

    public void Raise(T value)
    {
        response.Invoke(value);
    }
}