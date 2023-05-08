using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    [Header("Destruction Timer")]
    //After this time, the object will be destroyed
    public float timeToDestruction;

    void start()
    {
        //Execute function based on time to destruct
        Invoke("DestroyObject", timeToDestruction);
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}
