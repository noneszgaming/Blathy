using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pont : MonoBehaviour
{
    public Transform player;
    public Text pont;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pont.text = player.position.z.ToString("0");
    }
}
