using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletaGameObjekt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(transform.position.z>30){
            Destroy(gameObject);
        }
        else if(transform.position.z<-10){
            Destroy(gameObject);
        }
    }
}
