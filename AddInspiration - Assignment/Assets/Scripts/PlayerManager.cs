using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] 
    private GameObject _player;
    private Rigidbody2D _playerRigidBody;
    
    // Start is called before the first frame update
    void Start()
    {
        InputManager.Instance.OnTouchLeftSide += PlayerGoUp;
        InputManager.Instance.OnTouchLeftSideCancelled += PlayerGoDown;
        InputManager.Instance.OnTouchRightSide += PlayerShoot;

        _playerRigidBody = _player.GetComponent<Rigidbody2D>();
       
    }

    private void FixedUpdate()
    {
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, ScreenBoundaries.Left, ScreenBoundaries.Right);
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, ScreenBoundaries.Bottom, ScreenBoundaries.Top);
        transform.position = clampedPosition;
    }
    public static class ScreenBoundaries
    {
        public static float Left => Camera.main.ViewportToWorldPoint(Vector3.zero).x;
        public static float Right => Camera.main.ViewportToWorldPoint(Vector3.right).x;
        public static float Top => Camera.main.ViewportToWorldPoint(Vector3.up).y;
        public static float Bottom => Camera.main.ViewportToWorldPoint(Vector3.zero).y;
    }


    private void OnDisable()
    {
        InputManager.Instance.OnTouchLeftSide -= PlayerGoUp;
        InputManager.Instance.OnTouchLeftSideCancelled -= PlayerGoDown;
        InputManager.Instance.OnTouchRightSide -= PlayerShoot;
    }


    private void PlayerGoUp(Vector2 vector)
    {
        Debug.Log("Player Go up!");
        _playerRigidBody.gravityScale = -5;

    }
    private void PlayerGoDown(Vector2 vector)
    {
        Debug.Log("Player Go Down!");
        _playerRigidBody.gravityScale = 1;


    }
    private void PlayerShoot(Vector2 vector)
    {
        Debug.Log("Player Shoot!");

    }
    private

    // Update is called once per frame
    void Update()
    {
        
    }
}
