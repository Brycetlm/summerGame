using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    GameObject mainPlayer;
    GameObject plyerCamera;

    void Start()
    {
        mainPlayer = GameObject.FindGameObjectWithTag("Player");
        plyerCamera = this.gameObject;
    }

    
    void Update()
    {
        plyerCamera.transform.position = new Vector3(mainPlayer.transform.position.x, mainPlayer.transform.position.y, plyerCamera.transform.position.z);
    }
}
