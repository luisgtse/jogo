using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personagem : MonoBehaviour
{
    public float velocidade;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   
        MovimentoPlayer();
    }

    void MovimentoPlayer()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movimento = new Vector3(horizontal, 0f, vertical) * velocidade * Time.deltaTime;
        transform.Translate(movimento, Space.Self);

        if(Input.GetButtonDown("Jump")){
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }
    }
}
