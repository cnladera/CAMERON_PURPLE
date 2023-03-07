using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiggerExplosion : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Explosion Parts")]
    public GameObject explosion;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
