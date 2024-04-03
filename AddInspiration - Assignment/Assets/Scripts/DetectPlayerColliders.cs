using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayerColliders : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ammo")
        {
            PlayerManager.Instance.IncreaseAmmoAmmount();            
            Destroy(collision.gameObject);
            //Debug.Log("Player hit ammo refill!");
        }

        if (collision.tag == "Obstacle")
        {
            Debug.Log("Player is hit!");
            UIManager.Instance.GameOver();
            //Time.timeScale = 0;
            //Destroy(collision.gameObject);
            //Destroy(PlayerManager.Instance.GetPlayer());
        }
    }


}
