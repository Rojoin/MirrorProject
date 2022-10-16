using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordLogic : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject[] words;
    public    GameObject wordToReturn = null;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void checkMouseIsOver()
    {
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].GetComponent<Word>().IsMouseOver)
            {
                wordToReturn= words[i];
            }
        }

    }
   
}
