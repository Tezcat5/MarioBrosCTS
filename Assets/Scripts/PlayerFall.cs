using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerFall : MonoBehaviour

{
    private Rigidbody2D rBody;
    public float enemySpeed = 2;
    private float enemyDirection = 1;
    public Animator anim;
    private AudioSource source; 
    public AudioClip deathSound;
    private BoxCollider2D boxCollider;
    
    // Start is called before the first frame update
    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rBody.velocity.x > -0.1f && rBody.velocity.x < 0.1f)
        {
            enemySpeed = -enemySpeed;
        }
        rBody.velocity = new Vector2(enemyDirection * enemySpeed, rBody.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 3 ||collision.gameObject.tag == "Goombas")
        {
         if(enemyDirection == 1)
        {
            enemyDirection = -1;
        }
        else if(enemyDirection == -1)
        {
            enemyDirection = 1;
        }
        }

         if(collision.gameObject.layer == 3 ||collision.gameObject.tag == "Tuberias")
        {
         if(enemyDirection == 1)
        {
            enemyDirection = -1;
        }
        else if(enemyDirection == -1)
        {
            enemyDirection = 1;
        }
        }
        
        
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }

        
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Game over");
        }

    }

    public void GoombaDeath()
    {
        source.PlayOneShot(deathSound);
        boxCollider.enabled = false;
        rBody.gravityScale = 0;
        enemyDirection = 0;
        Destroy(gameObject, 0.5f);
    }
}