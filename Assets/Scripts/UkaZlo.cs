using System;
using UnityEngine;

public class UkaZlo : MonoBehaviour
{
    [SerializeField] private float _padok;

    private void Update()
    {
        gameObject.transform.position = new Vector2 (transform.position.x, 
            transform.position.y - (_padok * Time.deltaTime));
    }
}