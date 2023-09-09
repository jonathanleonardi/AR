using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasTransisi : MonoBehaviour
{
    public static string NamaScene;
    // public string ID;

    public void btn_scanAR(string nama)
    {
        this.gameObject.SetActive(true);
        NamaScene = nama;
        GetComponent<Animator>().Play("end");
        // SceneManager.LoadScene(NamaScene);
    }

    public void Object_InActive()
    {
        this.gameObject.SetActive(false);
    }

    public void Pindah_Scene()
    {
        SceneManager.LoadScene(NamaScene);
    }

    public void btn_Keluar()
    {
        Application.Quit();
    }
}
