using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(6)]

public class DetectPlayerColliders : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ammo")
        {
            PlayerManager.Instance.IncreaseAmmoAmmount(); 
            AudioManager.Instance.PlaySFX(3);
            Destroy(collision.gameObject);
            //Debug.Log("Player hit ammo refill!");
        }

        if (collision.tag == "Obstacle")
        {
            //Debug.Log("Player is hit!!!!!!");
            //PlayerManager.Instance.GameOver();
            AudioManager.Instance.PlaySFX(2);
            UIManager.Instance.GameOver();
            //Destroy(collision.gameObject);
            //Destroy(PlayerManager.Instance.GetPlayer());
        }
    }


}
