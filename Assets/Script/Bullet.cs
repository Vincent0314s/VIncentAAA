using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward*500);
        Destroy(gameObject,3f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Enemy") {
            if (collision.transform.GetComponent<Million>().hitPoint>0) {
                collision.transform.GetComponent<Million>().hitPoint -= 1;
                collision.transform.GetComponent<Renderer>().material.color = Random.ColorHSV();
                Destroy(gameObject);
            }
        }
    }
}
