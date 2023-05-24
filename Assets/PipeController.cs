using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    [SerializeField] float scrollSpeed = 5;
    float deadZone = -7.12f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < deadZone)
            Destroy(gameObject);
        else
            transform.Translate(Vector2.left * Time.deltaTime * scrollSpeed);
    }
}
