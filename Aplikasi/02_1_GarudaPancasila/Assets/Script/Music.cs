using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public static Music instance;

    public AudioClip[] AudioClip;
    List<AudioSource> Musik = new List<AudioSource>();

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Musik.Clear();
        for (int i = 0; i < AudioClip.Length; i++)
        {
            Musik.Add(gameObject.AddComponent<AudioSource>());
            Musik[i].clip = AudioClip[i];
        }
    }

    public void Play(int i)
    {
        Musik[0].Play();
    }
}
