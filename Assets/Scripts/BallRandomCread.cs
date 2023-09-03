using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BallRandomCread : MonoBehaviour
{
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
    }
    private void RandomeP(){
        pos=new Vector3 (0,9,Random.Range(0,17));
        Instantiate(ball, pos, transform.rotation);
    }
}
