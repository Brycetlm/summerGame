using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//挂载在凋落物上，要是被玩家碰到，就会消失
public class collect : MonoBehaviour
{
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D player)
    {
       if(player.tag=="Player")
        {
            Destroy(this.gameObject);
        }
    }
}
