using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathParticles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("virus");
            foreach (GameObject target in gameObjects)
			{
                GameObject.Destroy(target);
			}
        }
    }
}