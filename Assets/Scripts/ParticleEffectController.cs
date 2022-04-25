using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectController : MonoBehaviour
{
    // Start is called before the first frame update

    ParticleSystem particleSystem;
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            particleSystem.Play();
        }

        if(Input.GetKeyDown(KeyCode.Z))
        {
            particleSystem.Stop();
        }
    }

    public void Play()
    {
        
    }
}
