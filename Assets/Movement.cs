using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public Rigidbody2D Rbody;


    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    //LoadScene = Restart 
    // adforce puttar Spelaren. 
    // Relative force puttas spelaren åt sitt höger.
    // movePosion så flytas spelarens posisoin 
    // moveRotasion roterar den 

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Rbody.AddForce(new Vector2(10f, 0f));
        }
        if (Input.GetKey(KeyCode.A))
        {
            Rbody.AddForce(new Vector2(-10f, 0f));
        }
        if (Input.GetKey(KeyCode.S))
        {
            Rbody.AddForce(new Vector2(0f, -10f));
        }
        if (Input.GetKey(KeyCode.W))
        {
            Rbody.AddForce(new Vector2(0f, 10f));
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("SampleScene");
    }
}
