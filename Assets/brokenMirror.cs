using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class brokenMirror : MonoBehaviour
{
    [SerializeField] private SpriteRenderer currentSpriteRenderer;
    [SerializeField] private Sprite[] storedImages;
    private int imageCounter = 0;
    private int click = 0;
    public uint maxClicks = 10;
    public uint maxImageCounter = 4;

    void Start()
    {
        currentSpriteRenderer = GetComponent<SpriteRenderer>();
        currentSpriteRenderer.sprite = storedImages[imageCounter];
        imageCounter = 0;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            click++;
            if (click ==maxClicks && imageCounter<maxImageCounter)
            {
                imageCounter++;
                ChangeImage();
                click = 0;
            }
        }

        if (imageCounter == maxImageCounter)
        {
            Debug.Log("ROTO");
        }
       
    }

    void ChangeImage()
    {
        currentSpriteRenderer.sprite = storedImages[imageCounter];
    }
    
}
