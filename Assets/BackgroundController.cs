using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [SerializeField] float scrollSpeed = -1f;
    const float resetPoint = -3.62f;
    Vector3 defaultPosition;

    // Start is called before the first frame update
    void Start()
    {
        defaultPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < resetPoint)
            transform.position = defaultPosition;
        else
            transform.Translate(scrollSpeed * Time.deltaTime, 0, 0);
    }
}
