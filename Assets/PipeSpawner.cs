using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    float timer = 0;
    float spawnRateInSeconds = 2;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRateInSeconds)
            timer += Time.deltaTime;

        else {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        Instantiate(pipe, new Vector2(transform.position.x, Random.Range(-3f, 3.04f)), transform.rotation);
    }
}
