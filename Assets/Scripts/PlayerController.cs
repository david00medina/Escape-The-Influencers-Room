using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float speed = 5.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The player has been created!");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 frontwalk = new Vector3(0, 0, 1);
        Vector3 sidewalk = new Vector3(1, 0, 0);
        
        rb.AddForce(sidewalk * horizontalInput * speed * Time.deltaTime, ForceMode.VelocityChange);
        rb.AddForce(frontwalk * verticalInput * speed * Time.deltaTime, ForceMode.VelocityChange);
    }
}
