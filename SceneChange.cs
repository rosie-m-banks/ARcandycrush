using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene("HomePage");
    }
    public void Scene2()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
}