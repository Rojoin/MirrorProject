using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brokenMirror : MonoBehaviour
{
    [SerializeField] private SpriteRenderer currentSpriteRenderer;

    
    void Start()
    {
        currentSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
