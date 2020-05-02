using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float verticalInput;
    public float speed = 20.0f;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
        }
        
        
    }
}
