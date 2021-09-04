using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public GameObject boom;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        Instantiate(boom, this.gameObject.transform.position, this.gameObject.transform.rotation);
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        rend.enabled = false;
        Destroy(this.gameObject, audio.clip.length);
    }
}
