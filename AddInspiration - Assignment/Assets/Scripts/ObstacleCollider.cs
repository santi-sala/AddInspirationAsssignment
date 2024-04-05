using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(7)]
public class ObstacleCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Bullet")
        {
            Debug.Log("Bullet hit the obstacle");
            UIManager.Instance.UpdateScore();
            AudioManager.Instance.PlaySFX(1);
           // UIManager.Instance.GameOver();


            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
