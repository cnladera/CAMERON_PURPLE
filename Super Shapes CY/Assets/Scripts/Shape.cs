using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    //rigidbody for object 
    [Header("Rigidbody Object")]
    public Rigidbody2D rb;
    //shrinking speed
    [Header("Default Shrinking Speed")]
    public float shrinkSpeed = 3f;


    // Start is called before the first frame update
    void Start()
    {
        //rotation of the rigidbody
        //at a random range
        rb.rotation = Random.Range(0f, 360f);
        //local scale for the hexagon
        //equals one for all axes time
        //ten
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        //local scale equals for shrinking multuplied by
        //axis size multipled by game rate
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        //Local scale on x axis is less
        //or equals to 0.05
        if (transform.localScale.x <= .05f)
        {
            //destroy object
            Destroy(gameObject);
        }
    }
}
