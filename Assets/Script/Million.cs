using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Million : MonoBehaviour
{

    public Transform turret;
    public float moveSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.LookAt(new Vector3(turret.position.x,transform.position.y,turret.position.z));
        transform.Translate(0,0,moveSpeed * Time.deltaTime);
    }
}
