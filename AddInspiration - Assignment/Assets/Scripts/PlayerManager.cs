using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.EventSystems;
using UnityEngine;

public class PlayerManager : Singleton<PlayerManager>
{
    public event Action<int> OnChangeAmmo;

    [SerializeField] 
    private GameObject _player;
    [SerializeField]
    private GameObject _playerBullet;
    [SerializeField]
    Transform _playerBulletSpawnPoint;

    private Rigidbody2D _playerRigidBody;
    private float _bulletSpeed = 5f;
    private int _ammountOfAmmo = 5;

    
    // Start is called before the first frame update
    void Start()
    {
        InputManager.Instance.OnTouchLeftSide += PlayerGoUp;
        InputManager.Instance.OnTouchLeftSideCancelled += PlayerGoDown;
        InputManager.Instance.OnTouchRightSide += PlayerShoot;

        _playerRigidBody = _player.GetComponent<Rigidbody2D>();
        _playerBullet.GetComponent<Rigidbody2D>();
       
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
        if (_ammountOfAmmo > 0)
        {
            Debug.Log("Player Shoot!");
            GameObject bullet = Instantiate(_playerBullet, _playerBulletSpawnPoint.transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = transform.right * _bulletSpeed;
            _ammountOfAmmo--;
            OnChangeAmmo?.Invoke(_ammountOfAmmo);
        }
    }

    public void IncreaseAmmoAmmount()
    {
        _ammountOfAmmo++;
        OnChangeAmmo?.Invoke(_ammountOfAmmo);
    }


}
