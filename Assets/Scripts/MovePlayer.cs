using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 50f, hSpeed = 60f, _thrust = 500f;
    private Rigidbody _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * hSpeed * Time.fixedDeltaTime;
        float v = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;

        _rb.velocity = transform.TransformDirection(new Vector3(v, _rb.velocity.y, -h));
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Block")
        {
            _rb.AddForce(new Vector3(0,1,0) * _thrust);  
        }
    }
}
