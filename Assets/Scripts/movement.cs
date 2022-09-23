using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public bool isMoving;
    public float movementSpeed = 150f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isMoving = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isMoving)
        {
            //rb.AddForce(movementSpeed * Time.deltaTime, 0, 0);
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }
    }
}
