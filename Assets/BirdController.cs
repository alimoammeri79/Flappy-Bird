using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{
    AudioSource[] audioSources;
    Rigidbody2D rigidBody;
    [SerializeField] GameObject gameOverUi;
    [SerializeField] GameObject scoreText;

    int score = 0;
    [SerializeField] float flappPower = 9;
    bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        audioSources = GetComponents<AudioSource>();
        rigidBody = GetComponent<Rigidbody2D>();

        rigidBody.gravityScale = 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && isAlive) {
            rigidBody.velocity = Vector2.up * flappPower;
            audioSources[0].Play();
        }
    }

    // score logic
    void OnTriggerEnter2D(Collider2D other)
    {
        if(!isAlive)
            return;

        ++score;
        scoreText.GetComponent<Text>().text = score.ToString();
        audioSources[1].Play();
    }

   // gameover logic
    void OnCollisionEnter2D(Collision2D other)
    {   
        if(!isAlive)
            return;
        
        audioSources[2].Play();
        isAlive = false;
        gameOverUi.SetActive(true);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
