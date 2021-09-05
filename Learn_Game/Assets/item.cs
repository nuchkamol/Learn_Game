using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class item : MonoBehaviour
{
    public GameObject boom;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 45f * Time.deltaTime,0f));
    }

    void OnTriggerEnter(Collider other)
    {
        Instantiate(boom, this.gameObject.transform.position, this.gameObject.transform.rotation);
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        rend.enabled = false;
        Destroy(this.gameObject , audio.clip.length);
    }
}
