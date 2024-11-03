using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myrigidbody2d;
    public float flapstrength;
    public logicscript logic;
    public bool birdisalive = true;
    public AudioSource ambatukam;
    public AudioSource onmyway;
    

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
        onmyway.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)==true && birdisalive == true)
        {
            myrigidbody2d.velocity = Vector2.up * flapstrength;
        }

        if (transform.position.y > 20 || transform.position.y < -20)
        {
            logic.gameover();
            birdisalive=false;
        }
        if (birdisalive == false)
        {
            onmyway.Stop();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        ambatukam.Play();
        birdisalive = false;
    }
}
