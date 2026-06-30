using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestSimpleLogic : MonoBehaviour
{
    [SerializeField] private InputActionProperty _inputActionGrip;
    [SerializeField] private bool isTrue = false;
    [SerializeField] public Light _light = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _light.gameObject.SetActive(isTrue);
    }

    // Update is called once per frame
    void Update()
    {
        _light.gameObject.SetActive(!isTrue);
        isTrue = !isTrue;
        Debug.Log(_inputActionGrip.action.IsPressed()); 
    }
}
