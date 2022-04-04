using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MainGameManager.instance.Adjustscore(-1000);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
