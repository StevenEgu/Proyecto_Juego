using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MOVIMIENTO : MonoBehaviour
{
    float moveSpeed = 5f;
    public Rigidbody2D rb;
    public float speed = 5f;
    public float moveForce = 10;
    // public CharacterController controller;
    //public float speed = 6f;
    // public NavMeshAgent agent;
    // public Transform tarjet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        float moveY = Input.GetAxis("Jump");
        transform.Translate(new Vector2(moveX, moveY) * moveSpeed * Time.deltaTime);

        // Vector3 move=new Vector3 (moveX, 0, moveZ) * speed * Time.deltaTime;rb.MovePosition(rb.position + move);
        Vector3 force = new Vector2(moveX, moveY) * moveForce; rb.AddForce(force);
        //rb.velocity=new Vector3 (moveX, moveY, moveZ)*speed;
        //Vector3 move=transform.right*moveX+transform.forward*moveZ+transform.up*moveY;
        // controller.Move(move * speed * Time.deltaTime);


    }
}
