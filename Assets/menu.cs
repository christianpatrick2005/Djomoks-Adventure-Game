using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void jomok1 ()
    {
        SceneManager.LoadSceneAsync (2);
    }
    public void jomok2 ()
    {
        SceneManager.LoadSceneAsync (3);
    }
    public void jomok3 ()
    {
        SceneManager.LoadSceneAsync (4);
    }
    public void kembali()
    { 
        SceneManager.LoadSceneAsync (0);
    }
    public void kembali1()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
