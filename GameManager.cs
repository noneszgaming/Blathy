using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool Vegevan = false;
    public float RestartIdo = 2f;
    public GameObject completeLevelUI;

    public void LevelKesz ()
    {
        completeLevelUI.SetActive(true);
    }

    public void GameOver()
    {
        if (Vegevan == false)
        {
            Vegevan = true;
            Debug.Log("Vége a Játéknak ");

            Invoke("Res", RestartIdo);
        }
    }
    void Res ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
