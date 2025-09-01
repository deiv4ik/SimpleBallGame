using UnityEngine;

public class ChangeColors : MonoBehaviour
{
    private MeshRenderer _mesh;

    void Awake()
    {
        _mesh = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            _mesh.material.color = Color.green;
        }
        
        if (Input.GetKeyDown(KeyCode.R)) {
            _mesh.material.color = Color.red;
        }
    }
}
