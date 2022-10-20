using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class brokenMirror : MonoBehaviour
{
    [SerializeField] private SpriteRenderer currentSpriteRenderer;
    [SerializeField] private Sprite[] storedImages;
    [SerializeField] private LevelLoader ll;
    private int imageCounter = 0;
    private int click = 0;
    public uint maxClicks = 10;
    public uint maxImageCounter = 3;

    void Start()
    {
        currentSpriteRenderer = GetComponent<SpriteRenderer>();
        currentSpriteRenderer.sprite = storedImages[imageCounter];
        imageCounter = 0;
        ll = FindObjectOfType<LevelLoader>();
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
            ll.LoadNextLevel();
        }
       
    }

    void ChangeImage()
    {
        currentSpriteRenderer.sprite = storedImages[imageCounter];
    }
    
}
