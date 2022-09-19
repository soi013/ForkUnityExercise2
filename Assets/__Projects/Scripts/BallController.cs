using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private float speedAnglePerSec = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, speedAnglePerSec * Time.deltaTime);
    }
}
