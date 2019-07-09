using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
   public void Easy()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void Hard()
    {
        SceneManager.LoadScene("Hard");
    }
    public void End()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
        UnityEngine.Application.Quit();
#endif
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) End();
    }
}
