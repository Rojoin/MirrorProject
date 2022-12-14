using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class cleanMirror : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sr;
    public float cleanForce = 0.1f;
    public float opacity = 1.0f;
    [SerializeField] private Vector2 startTouchPos = Vector2.zero;
 
    [SerializeField] private Vector2 endtTouchPos = Vector2.zero;
    [SerializeField] private LevelLoader ll;
    void Start()
    {
        sr.material.color = new Color(sr.material.color.r, sr.material.color.b, sr.material.color.g, opacity);
        ll = FindObjectOfType<LevelLoader>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            startTouchPos = Input.mousePosition;
        }
    
        if (Input.GetMouseButtonUp(0))
        {
            endtTouchPos = Input.mousePosition;
            if (Mathf.Abs(startTouchPos.x) != Mathf.Abs(endtTouchPos.x))
            {
                opacity -= cleanForce;
                FMODUnity.RuntimeManager.PlayOneShotAttached("event:/SFX/Game/LimpiarEspejo", this.gameObject);
            }
        }

        sr.material.color = new Color(sr.material.color.r, sr.material.color.b, sr.material.color.g, opacity);
        if (opacity <= 0)
        {
            ll.LoadNextLevel();
        }
    }


}
