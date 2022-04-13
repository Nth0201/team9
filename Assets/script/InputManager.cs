using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private TouchControlle touchController;
    // Start is called before the first frame update
    private void Awake()
    {
        touchController = new TouchControlle();
    }

    private void OnEnable()
    {
        touchController.Enable();
    }

    private void OnDisable()
    {
        touchController.Disable();
    }

    private void Start()
    {

    }
}
