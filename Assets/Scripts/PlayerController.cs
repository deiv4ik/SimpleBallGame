using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 50f;
    private Rigidbody _rb;

    public TextMeshProUGUI score_text;
    private int score = 0;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        _rb.AddForce(new Vector3(h,1,v) * speed * Time.fixedDeltaTime); 
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "CollectiveCube")
        {
            Destroy(other.gameObject);
            score++;

            if (score != 5)
            {
                score_text.text = "Score: " + score;
            }
            else
            {
                score_text.text = "You win!";
            }
        }
    }
}
