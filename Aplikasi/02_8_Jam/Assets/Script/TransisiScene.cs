using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransisiScene : MonoBehaviour
{
    public static string NamaScene;

    public void AR_scan(string nama)
    {
        this.gameObject.SetActive(true);
        NamaScene = nama;
        GetComponent<Animator>().Play("end");
    }

    public void Object_InActive()
    {
        this.gameObject.SetActive(false);
    }

    public void pindahScene()
    {
        SceneManager.LoadScene(NamaScene);
    }

    public void Keluar()
    {
        Application.Quit();
    }
}
