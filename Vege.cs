using UnityEngine;

public class Vege : MonoBehaviour
{

    public GameManager GameManager;
    void OnTriggerEnter ()
    {
        GameManager.LevelKesz();

    }
}
