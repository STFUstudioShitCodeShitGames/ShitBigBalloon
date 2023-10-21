using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dobri : MonoBehaviour
{
    [SerializeField] private float _lopashuk;
    [SerializeField] private RururClo _rurur;
    [SerializeField] private RectTransform _koloo;

    private float _hjX;
    public BoxCollider2D Jolk => _rurur.Gollider;

    private Vector2 _jart;
    
    private void Start()
    {
        _hjX = (Jolk.size.x * _koloo.localScale.x) / 2f;
    }

    private void Update()
    {
        if (Input.touchCount == 0)
            return;

        Touch touch = Input.GetTouch(0);

        switch (touch.phase)
        {
            case TouchPhase.Began:
                _jart = touch.position;
                break;

            case TouchPhase.Moved:
                Debug.Log(2 * (touch.position.x) / Screen.width);
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.GetComponent<UkaZlo>())
            return;
        
        
    }
}
