using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallDetection : MonoBehaviour
{

    RaycastHit hit;
    public movement p_movement;

    // Start is called before the first frame update
    void Start()
    {
        p_movement = GameObject.FindObjectOfType<movement>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, p_movement._targetDiection);
        Debug.DrawRay(transform.position, p_movement._targetDiection, Color.red);

        if(Physics.Raycast(ray, out hit, 1f))
        {
            if(hit.collider.tag == "pared")
            {
                p_movement._isMoving = false;
            }
        }
    }
}
