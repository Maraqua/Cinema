using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
  public static Stack<int> scenes = new Stack<int>();
  int numScenes = scenes.Count;
  public void loadScene(int newScene)
  {
    scenes.Push(newScene);
    SceneManager.LoadScene(newScene);
  }
  public void previousScene()
  {
    if (numScenes != 0 && numScenes != 1)
    {
      scenes.Pop();
      SceneManager.LoadScene(scenes.Peek());
    }
    else if (numScenes == 1)
    {
      loadScene(0);
    }
  }
  public void ExitApp()
  {
    Application.Quit();
    Debug.Log("Quit imax");
  }
}