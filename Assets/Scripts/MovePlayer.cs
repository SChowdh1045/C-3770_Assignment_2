using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class MovePlayer : MonoBehaviour
{
    Rigidbody rb;

    int doubleJump = 0;
    float jumpForce = 10f;
    bool isSpacePressed = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxis("Horizontal");
        float dirZ = Input.GetAxis("Vertical"); // Says "Vertical", but really means forward/backward movement

        rb.velocity = new Vector3(dirX * 5f, rb.velocity.y, dirZ * 5f);


        if (Input.GetKeyDown("space") && doubleJump < 2)
        {
            doubleJump++;
            isSpacePressed = true;
        }
    }

    private void FixedUpdate()
    {
        if(isSpacePressed)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isSpacePressed = false; // If not for this line, the capsule/player would keep going upwards non-stop
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            doubleJump = 0;
        }
    }
}
