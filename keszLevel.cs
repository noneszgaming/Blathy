using UnityEngine;
using UnityEngine.SceneManagement;

public class keszLevel : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
