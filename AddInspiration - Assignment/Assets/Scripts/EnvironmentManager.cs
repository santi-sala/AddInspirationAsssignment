using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _environment;
    [SerializeField]
    private float _speed = -5f; // Speed at which the object moves
    [SerializeField]
    private GameObject _background;
    [SerializeField]
    private Material _material;
    private float _offSet;
    private int _levelcounter = 0;

    private void Start()
    {
        _material = _background.GetComponent<Renderer>().material;
    }


    void Update()
    {
        if (_levelcounter > 2)
        {
            _speed += 1;
            _levelcounter = 0;
        }
        // Calculate the movement amount
        float movement = _speed * Time.deltaTime;

        // Move the object
       _environment.transform.Translate(-movement, 0, 0);

        if (_speed > 6)
        {
            _offSet += (Time.deltaTime * 5) / 10;
            _material.SetTextureOffset("_MainTex", new Vector2(_offSet, 0));
            //Debug.Log("k pasa");
        } else
        {
            _offSet += (Time.deltaTime * (_speed - 1)) / 10;
            _material.SetTextureOffset("_MainTex", new Vector2(_offSet, 0));
            //Debug.Log("sup");
        }

    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Environment")
        {
            Debug.Log("Trigger detected");
            Transform parentTRansform = collision.transform.parent;
            parentTRansform.transform.position = new Vector3(45, 0, 0);
            _levelcounter += 1;

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Environment")
        {
            Debug.Log("Collision detected");
        }
    }
}
