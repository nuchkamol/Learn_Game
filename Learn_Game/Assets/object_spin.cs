using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_spin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
     //   transform.Rotate(new Vector3(0f, 45f * Mathf.Sin(Time.time * 2f), 0f));
        transform.rotation = Quaternion.Euler(20f * Mathf.Sin(Time.time * 2f), 0f , 4.383f);
    }

}
