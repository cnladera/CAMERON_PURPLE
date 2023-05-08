using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //movement speed
    [Header("Default Movement Speed")]
    public float moveSpeed = 600f;
    //movement float
    float movement = 0f;


    // Start is called before the first frame update
    void Start()
    {
        //game running at a playing state
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
        //Movement equals to the horizontal
        //axis movement (Left or Right)
        movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        //object transformation rotates around
        //an object using the settings
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    //if object collides with a 
    //collider with a trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Game is at a stopping state
        Time.timeScale = 0;
    }

}
