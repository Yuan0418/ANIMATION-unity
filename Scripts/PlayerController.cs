using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Reference to the Animator component of the player
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        // Link the "vertical" parameter in the animator to the player's vertical input
        anim.SetFloat("vertical", Input.GetAxis("Vertical"));// 1 0 -1
        // Link the "horizontal" parameter in the animator to the player's horizontal input
        anim.SetFloat("horizontal", Input.GetAxis("Horizontal"));// 1 0 -1
        //Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //if (dir != Vector3.zero)
        //{
            //transform.rotation = Quaternion.LookRotation(dir);
           // transform.Translate(Vector3.forward * 2 * Time.deltaTime);
       // }
    }
}
