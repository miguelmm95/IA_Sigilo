using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private GameObject _targetObject;
    private float _movementSpeed = 5f;

    public Rigidbody _rb;
    public bool _isMoving;
    public Vector3 _targetDiection;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _isMoving = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _targetDiection = (_targetObject.transform.position - transform.position).normalized;

        if (_isMoving)
        {
            Vector3 velocity = _targetDiection * _movementSpeed * Time.deltaTime;
            transform.Translate(velocity);
        }
    }
}
