using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private float speedAnglePerSec = 0.1f;

    [SerializeField]
    Rigidbody _rigidbody;

    [SerializeField]
    private float forceByInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var vInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up, speedAnglePerSec * Time.deltaTime);
        _rigidbody?.AddForce(Vector3.forward * forceByInput * vInput * Time.deltaTime);
    }
}
