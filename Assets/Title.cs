using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// ��
public class Title : MonoBehaviour
{
    public string _sceneName = "SampleScene";

    public void LoadScene()
    {
        Debug.Log("Load Scene.");
        SceneManager.LoadScene(_sceneName);
    }

    void Start()
    {

    }

    void Update()
    {

    }
}