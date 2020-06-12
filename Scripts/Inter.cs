using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inter : MonoBehaviour
{
    private Animation ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animation>();
    }

    private void OnTriggerEnter(Collider other)
    {
        ani.Play("Interactive");
    }
}