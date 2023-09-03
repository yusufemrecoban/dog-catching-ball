using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.0f;
    public GameObject Mertinki;
    public float jumpInput ;
    public GameObject ball;
    public Vector3 pos = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RandomeP",2,1);
    }

    // Update is called once per frame
    void Update()
    {
        /* if(Input.GetKeyDown(KeyCode.Space)){
        Vector3 pos = transform.position;
        pos.y += speed * Time.deltaTime;
        }
        jumpInput = Input.GetAxis("Jump");
        transform.Translate(Vector3.up * Time.deltaTime*speed*jumpInput);*/
        if(Input.GetKeyDown(KeyCode.LeftAlt)){
            Instantiate(Mertinki, transform.position, transform.rotation);
        }
        
    }
    private void RandomeP(){
        pos=new Vector3 (0,9,Random.Range(0,17));
        Instantiate(ball, pos, transform.rotation);
    }
}
