using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public Rigidbody rb;
    public float elore = 2000f;
    public float jobbra_balra_irány = 500f;

    void FixedUpdate()
    {
        rb.AddForce(0,0,elore * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(jobbra_balra_irány * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-1 * jobbra_balra_irány * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }


        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }

    }
}
