﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    public Transform player;
    public Vector3 camerapos ;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + camerapos;
    }
}
