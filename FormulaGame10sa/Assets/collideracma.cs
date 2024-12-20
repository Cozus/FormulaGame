using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideracma : MonoBehaviour
{
    public Collider2D f1lers;
    public Collider2D f2lers;
    public Collider2D f3lers;
    public Collider2D f4lers;
    public Collider2D f5lers;
    public Collider2D f6lers;
    public Collider2D f7lers;
    public Collider2D f8lers;
    public Collider2D f9lers;
    public Collider2D f10lers;


    void Start()
    {
        Invoke("acılbakan", 0.5f);
        
    }

    void acılbakan()
    {
        f1lers.enabled = true;
        f2lers.enabled = true;
        f3lers.enabled = true;
        f4lers.enabled = true;
        f5lers.enabled = true;
        f6lers.enabled = true;
        f7lers.enabled = true;
        f8lers.enabled = true;
        f9lers.enabled = true;
        f10lers.enabled = true;

    }

    
    void Update()
    {
        
    }
}
