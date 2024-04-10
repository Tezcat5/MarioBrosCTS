using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BCMManager : MonoBehaviour
{
    AudioSource source;

    public AudioClip lv1Music;

    void Awake()
    {
       source = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        source.clip = lv1Music;
        source.Play();
    }

    // Update is called once per frame
    
}
