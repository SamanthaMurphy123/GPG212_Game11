using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string sceneToLoad;

    void LoadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
