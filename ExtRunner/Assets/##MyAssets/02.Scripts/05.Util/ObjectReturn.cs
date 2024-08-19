using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectReturn : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PoolObject")) 
            PoolingSystem.Instance.ReturnObject(
                other.gameObject.GetComponentInParent<ObjectPool>().gameObject.name, 
                other.gameObject);
    }
}
