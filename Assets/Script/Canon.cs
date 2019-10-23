using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{

    public LayerMask ground;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit, Mathf.Infinity))
        {
            Vector3 newpos = new Vector3(hit.point.x,transform.position.y,hit.point.z);
            transform.LookAt(newpos);

        }
    }
}
