using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    private float speed = 10;
    private float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // horizontal movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.back * Time.deltaTime * speed * horizontalInput);
    }
}
