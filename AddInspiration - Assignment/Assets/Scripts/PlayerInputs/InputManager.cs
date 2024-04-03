using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;


public class InputManager : Singleton<InputManager>
{
    public event Action<Vector2> OnTouchLeftSide;
    public event Action<Vector2> OnTouchLeftSideCancelled;
    public event Action<Vector2> OnTouchRightSide;


    public event Action<Vector2> OnTouchPressStarted;
    public event Action<Vector2> OnTouchPressCanceled;

    //public delegate void TouchTapEvent();
    //public event TouchTapEvent OnTouchTap;
    //public delegate void TouchHoldEvent();
    //public event TouchHoldEvent OnTouchHold;
    //public delegate void TouchPressEvent();
    //public event TouchPressEvent OnTouchPress;

    PlayerInputs playerInputActions;
    EventSystem eventSystem;



    protected override void Awake()
    {
        base.Awake();
        eventSystem = EventSystem.current;
        playerInputActions = new PlayerInputs();
        playerInputActions.Player.Enable();
    }

    private void Start()
    {
        //playerInputActions.Player.TouchInput.performed += TouchInput_performed;
        playerInputActions.Player.TouchTap.performed += TouchTap_performed;
        //playerInputActions.Player.TouchHold.performed += TouchHold_performed;
        playerInputActions.Player.TouchPress.started += TouchPress_started;
        //playerInputActions.Player.TouchPress.performed += TouchPress_performed;
        playerInputActions.Player.TouchPress.canceled += TouchPress_canceled;
    }

    private void TouchPress_started(InputAction.CallbackContext obj)
    {
        Vector2 touchPosition = playerInputActions.Player.TouchInput.ReadValue<Vector2>();
        //Debug.Log("touch position is: " + touchPosition);
        //Debug.Log("Screen width is: " + Screen.width);

        if (touchPosition.x < Screen.width / 2 )
        {
            Debug.Log("Pressed performed");
            Debug.Log("Left side");
            OnTouchLeftSide?.Invoke(touchPosition);
        }
        
    }

    private void TouchTap_performed(InputAction.CallbackContext obj)
    {
        Vector2 touchPosition = playerInputActions.Player.TouchInput.ReadValue<Vector2>();
        //Debug.Log("touch position is: " + touchPosition);
        //Debug.Log("Screen width is: " + Screen.width);

        if (touchPosition.x > Screen.width / 2)
        {
            Debug.Log("Tap performed");
            Debug.Log("Right side");
            OnTouchRightSide?.Invoke(touchPosition);
        }    
    }

    private void TouchPress_canceled(InputAction.CallbackContext obj)
    {
        Vector2 touchPosition = playerInputActions.Player.TouchPosition.ReadValue<Vector2>();
        //Debug.Log("Canel;e");
        OnTouchPressCanceled?.Invoke(touchPosition);

        OnTouchLeftSideCancelled?.Invoke(touchPosition);

    }


    /*
    private void TouchPress_started(InputAction.CallbackContext obj)
    {
        Vector2 touchPosition = playerInputActions.Player.TouchPosition.ReadValue<Vector2>();
        //Debug.Log(touchPosition);
        OnTouchPressStarted?.Invoke(touchPosition);
    }

    private void TouchPress_performed(InputAction.CallbackContext obj)
    {
        //Vector2 touchPosition = playerInputActions.Player.TouchPosition.ReadValue<Vector2>();
        //Debug.Log("Press " + obj.phase);
        //OnTouchPress?.Invoke(touchPosition);
    }    

    private void TouchHold_performed(InputAction.CallbackContext obj)
    {
        //Debug.Log("Hold " + obj.phase);
    }
    */


}
