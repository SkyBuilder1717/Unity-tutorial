using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // import of number
        int health = 3;

        // Printing in console
        print("Npc health is " + health);
    }

    // Update is called once per frame
    void Update()
    {
        // speed of npc
        int speed = 1;
        // import of vector
        Vector3 newPosition = transform.position;
        // algoritmika script
        newPosition.z += speed * Time.deltaTime;
        // pinned
        transform.position = newPosition;
    }
}
