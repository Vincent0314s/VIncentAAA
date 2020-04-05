using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public LayerMask ground;
    public Transform firePoint;
    public GameObject bullet;

    public int currentHP;

    void Start()
    {
        
    }

    
    void Update()
    {
        MouseLook();
        Shot();
    }

    void MouseLook() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            Vector3 newpos = new Vector3(hit.point.x, transform.position.y, hit.point.z);
            transform.LookAt(newpos);

        }
    }

    void Shot() {
        if (Input.GetMouseButtonDown(0)) {
            Instantiate(bullet,firePoint.position,firePoint.rotation);
        }
    }
}
