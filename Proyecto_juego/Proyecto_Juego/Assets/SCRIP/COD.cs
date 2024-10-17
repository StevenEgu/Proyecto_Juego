using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class COD : MonoBehaviour
{
    Rigidbody2D rb;
    float moveSpeed = 5f, dirX;

    [SerializeField]
    GameObject CODPANEL, closedSafe, openedSafe;

    public static bool isSafeOpened=false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        CODPANEL.SetActive(false);
        closedSafe.SetActive(true);
        openedSafe.SetActive(false);
    }

    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * moveSpeed;
        if (isSafeOpened ) 
        { 
            CODPANEL.SetActive(false);
            closedSafe.SetActive(false );
            openedSafe.SetActive(true);
        }

    }
    void FixedUpdate()
    {
        rb.velocity=new Vector2 (dirX,rb.velocity.y);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        { 
            CODPANEL.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CODPANEL.SetActive(false) ;
        }
    }
}
