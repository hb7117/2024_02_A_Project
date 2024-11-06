using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Vehicle : MonoBehaviour
{
    public float speed = 10.0f;
    
    public virtual void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public abstract void Horn();
}
