using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 5.0f;
    public float turnSpeed = 5.0f;
    public Rigidbody rb;
    public bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!alive)
        {
            return;
        }
        
        Vector3 fwd = transform.forward*Time.fixedDeltaTime *speed;
        Vector3 horzntl = transform.right * Time.fixedDeltaTime* horizontalInput * turnSpeed;
        rb.MovePosition(rb.position+ fwd +horzntl);


    }
    private void Update()
    {
        speed += 0.5f * Time.deltaTime;
        turnSpeed += 0.1f * Time.deltaTime;
        horizontalInput = Input.GetAxis("Horizontal");
        if (transform.position.y < -5)
        {
            Die();
        }
    }
    public void Die()
    {
        alive= false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        DaliaCounter.dCounter = 0;
    }
}
