using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class item : MonoBehaviour
{
    public GameObject boom;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    void Update()
    {
        transform.Rotate(new Vector3(0f, 45f * Time.deltaTime, 0f));
    }

    void OnTriggerEnter(Collider other)
    {
        gameManager.nScore += 2;
        Text txt;
        txt = GameObject.Find("/Canvas/txtScore").GetComponent<Text>();
        txt.text = "Score : " + gameManager.nScore;

        Instantiate(boom, this.gameObject.transform.position, this.gameObject.transform.rotation);
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        rend.enabled = false;
        Destroy(this.gameObject, audio.clip.length);
    }
}
