using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{

    public void OnApplicationPause(bool pause)
    {
        
    }

    //Loads scene
    public void ChangeScene(int sceneNumber)
    {
        StartCoroutine(LoadYourAsyncScene(sceneNumber));
    }

    public void Test()
    {
        Debug.Log("Hello World");
    }

    //Loads scene in the background
    IEnumerator LoadYourAsyncScene(int sceneBuildIndex)
    {
        AsyncOperation asycLoad = SceneManager.LoadSceneAsync(sceneBuildIndex);

        while(!asycLoad.isDone)
        {
            yield return null;
        }
        Debug.Log("Scene should load");
    }
}
