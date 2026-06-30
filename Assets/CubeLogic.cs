using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class CubeLogic : MonoBehaviour
{
    [SerializeField] private XRSimpleInteractable interactable;
    [SerializeField] private float holdDuration = 3f;
    [SerializeField] private UnityEvent onLongPress;

    private bool isPressing = false;
    private float pressTimer = 0f;
    private bool actionTriggered = false;

    private void OnEnable()
    {
        interactable.selectEntered.AddListener(OnPressStart);
        interactable.selectExited.AddListener(OnPressEnd);
    }

    private void OnDisable()
    {
        interactable.selectEntered.RemoveListener(OnPressStart);
        interactable.selectExited.RemoveListener(OnPressEnd);
    }

    private void OnPressStart(SelectEnterEventArgs args)
    {
        isPressing = true;
        pressTimer = 0f;
        actionTriggered = false;
    }

    private void OnPressEnd(SelectExitEventArgs args)
    {
        isPressing = false;
        pressTimer = 0f;
    }

    private void Update()
    {
        if (isPressing && !actionTriggered)
        {
            pressTimer += Time.deltaTime;

            if (pressTimer >= holdDuration)
            {
                actionTriggered = true;
                onLongPress.Invoke();
            }
        }
    }
}