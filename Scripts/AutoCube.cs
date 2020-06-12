using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCube : MonoBehaviour
{
    private Animation ani;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //animation state
        AnimationState state = ani["up"];
        state.time = 0;
        state.speed = 1;
        ani.Play("up");
    }

    private void OnTriggerExit(Collider other)
    {
        //animation state
        AnimationState state = ani["up"];
        state.time = state.length;
        state.speed = -1;//reverse play
        ani.Play("up");
    }
}
