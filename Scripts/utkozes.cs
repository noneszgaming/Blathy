
using UnityEngine;

public class utkozes : MonoBehaviour
{
    public Object mozgas;
    void OnCollisionEnter (Collision utkozesInfo)
    {
        if (utkozesInfo.collider.tag == "akadaly")
        {
            mozgas.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }



}
