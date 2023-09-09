using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KumpulanSuara : MonoBehaviour
{
    public static KumpulanSuara instance;
    public bool isPlaying = false;

    public AudioClip[] AudioClip;
    List<AudioSource> Musik = new List<AudioSource>();
    private int ID;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Musik.Clear();
        for (int i = 0; i < AudioClip.Length; i++) {
            Musik.Add(gameObject.AddComponent<AudioSource>());
            Musik[i].clip = AudioClip[i];
        }
    }

    public void Play(int i) {
        if (isPlaying == false) {
            ID = i;
            Musik[i].Play();
        }
    }

    public void Pause(int i)
    {
        Musik[i].Pause();
        isPlaying = false;
    }

    public void Restart(int i)
    {
        Musik[i].Stop();
        Musik[i].Play();
    }

    public void Stop(int i)
    {
        Musik[i].Stop();
        isPlaying = false;
    }

    void Update()
    {
        if (!Musik[ID].isPlaying) {
            GerakSalsa gerakAnim = FindObjectOfType<GerakSalsa>();
            gerakAnim.stopAnimator();
            isPlaying = false;
        }
    }

    public void Check()
    {
        isPlaying = true;
    }
}
