using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Million : MonoBehaviour
{

    public Transform turret;
    public float moveSpeed;

    public int hitPoint;
    public int score;

    void Start()
    {
        turret = FindObjectOfType<Canon>().transform;
    }

    void Update()
    {
        Move();
        if (hitPoint <= 0) {
            Destroy(gameObject);
        }
    }

    private void Move()
    {
        if (turret) {
            transform.LookAt(new Vector3(turret.position.x, transform.position.y, turret.position.z));
            transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Turret") {
            if (collision.transform.GetComponent<Canon>().currentHP > 0)
            {
                collision.transform.GetComponent<Canon>().currentHP -= 1;
                Destroy(gameObject);
            }
        }
    }

    private void OnDestroy()
    {
        if (hitPoint <= 0) {
            GameControl.i.totalScore += score;
        }
    }
}
