using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroying : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // destrying game object in the game
        Destroy(gameObject);
        print("Object cube destroyed!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
