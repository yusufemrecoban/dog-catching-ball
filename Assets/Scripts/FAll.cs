using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FAll : MonoBehaviour
{
    public float fallSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime*fallSpeed);
        if(transform.position.y<-1){
            Destroy(gameObject);
        }
        
    }
}
