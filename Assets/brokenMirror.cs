using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class brokenMirror : MonoBehaviour
{
    [SerializeField] private SpriteRenderer currentSpriteRenderer;
    [SerializeField] private SpriteRenderer[] storedImages;
    private int imageCounter = 0;

    void Start()
    {
        currentSpriteRenderer = GetComponent<SpriteRenderer>();
        currentSpriteRenderer = storedImages[imageCounter];
        imageCounter = 0;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            imageCounter++;
        }

       
    }

    void ChangeImage()
    {
        if (imageCounter == 10)
        {
            currentSpriteRenderer = storedImages[imageCounter / 10];
        }
    }
    
}
