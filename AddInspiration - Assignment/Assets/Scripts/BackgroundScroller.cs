using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [Range(-1f, 1f)]
    [SerializeField]
    private float _scrollSpeed = 0.5f;

    private float _offSet;
    private Material _material;

    // Start is called before the first frame update
    void Start()
    {
        _material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        _offSet += (Time.deltaTime * _scrollSpeed) / 10;
        _material.SetTextureOffset("_MainTex", new Vector2(_offSet, 0));
    }
}
