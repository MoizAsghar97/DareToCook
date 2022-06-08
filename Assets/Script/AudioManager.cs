using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public AudioSource audioSource;
    public static AudioManager instance = null;
	private void Awake()
    {
        if(instance==null)
        {
           instance=this;
           DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    
    }

    public void PlayMusic()
	{
		audioSource.Play();
	}

   
}
