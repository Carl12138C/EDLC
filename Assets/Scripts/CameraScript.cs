using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        var cameraPos = transform.position;
        var playerPos = player.transform.position;
        cameraPos.x = playerPos.x;
        cameraPos.y = playerPos.y;
        if(cameraPos.x >= 2)
        {
            cameraPos.x = 2;
        }
        if(cameraPos.x <= -2)
        {
            cameraPos.x = -2;
        }
        if (cameraPos.y <= (float)-0.5)
        {
            cameraPos.y = (float)-0.5;
        }

        transform.position = cameraPos;
    }
}
