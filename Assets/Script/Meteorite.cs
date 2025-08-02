using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteo : MonoBehaviour
{
    public GameObject ball;
    private float count = 1.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count -= Time.deltaTime;
        if(count <= 0)
        {
            Instantiate(ball, new Vector3(10, 16, 10), Quaternion.identity);
            count = 1.0f;
        }
    }
}
