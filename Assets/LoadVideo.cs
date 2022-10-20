using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LoadVideo : MonoBehaviour
{
    [SerializeField] private LevelLoader ll;
    [SerializeField] private VideoClip currentClip;
    [SerializeField] private SpriteRenderer sr;
    private VideoPlayer vp;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = new Color(1, 1, 1, 0);
        vp = GetComponent<VideoPlayer>();
        vp.Prepare();
        vp.clip = currentClip;
        ll = FindObjectOfType<LevelLoader>();
    }

    void Update()
    {


        videoBuffer();
        if (vp.isPrepared)
        {
            sr.color = new Color(1, 1, 1, 1);
        }
        if (!vp.isPlaying)
        {
            ll.LoadNextLevel();
        }
    }

    IEnumerator videoBuffer()
    {
        vp.Prepare();
        while (!vp.isPrepared)
        {
            sr.color = new Color(1, 1, 1, 0);

            yield return new WaitForEndOfFrame();
        }

    }

   
    // Update is called once per frame

}
