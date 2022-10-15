using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Word : MonoBehaviour
{
    [SerializeField] private Collider2D cl;
    // Start is called before the first frame update
    void Start()
    {
        cl = GetComponentInChildren<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
