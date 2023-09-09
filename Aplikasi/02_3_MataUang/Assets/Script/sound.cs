using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public static sound instance;
    public int ID;

    public AudioClip[] AudioClip;
    public AudioSource AudioSource;
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
        Musik[ID].Play();
    }

    public void nextSuaraStop()
    {
        if (ID - 1 == -1)
        {
            Musik[9].Stop();
        }
        else
        {
            Musik[ID - 1].Stop();
        }
    }

    public void prevSuaraStop()
    {
        if (ID + 1 == 10)
        {
            Musik[0].Stop();
        }
        else
        {
            Musik[ID + 1].Stop();
        }
    }

    public void changeSound(bool change)
    {
        if (change)
        {
            ID++;
        }
        else
        {
            ID--;
        }

        if (ID == 10)
        {
            ID = 0;
        }
        else if (ID == -1)
        {
            ID = 9;
        }
    }
}