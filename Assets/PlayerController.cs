using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MainGameManager.instance.Adjustscore(3400);
    }

    // Update is called once per frame
    void Update()
    {

    }
   
}
