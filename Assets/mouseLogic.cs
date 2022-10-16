using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLogic : MonoBehaviour
{
    public GameObject word;
    private wordLogic wl;
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        wl = GetComponent<wordLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        word = wl.wordToReturn;
        if (Input.GetMouseButton(0)&& word != null)
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            word.transform.position = pos;
        }
    }







}
