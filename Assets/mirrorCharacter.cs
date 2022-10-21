using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class mirrorCharacter : MonoBehaviour
{
    [SerializeField] private int wordsOnFace;

    [SerializeField] private Collider2D cl;
    [SerializeField] private LevelLoader ll;
    [SerializeField] private bool startTime = false;
    private HashSet<Collider2D> colliders = new HashSet<Collider2D>();
    [SerializeField] private bool isHeadEmpty;
    public HashSet<Collider2D> GetColliders() { return colliders; }


    void Start()
    {
        ll = FindObjectOfType<LevelLoader>();
        cl = GetComponentInChildren<Collider2D>();
        isHeadEmpty = false;
        wordsOnFace = 7;
        StartCoroutine(waitSeconds());
    }

  
    void Update()
    {
      wordsOnFace = GetColliders().Count;
      if (isHeadEmpty && startTime)
      {
          Debug.Log("Flaco porque");
          ll.LoadNextLevel();
      }

     

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        colliders.Add(other); //hashset automatically handles duplicates
        wordsOnFace = GetColliders().Count;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        colliders.Remove(other);
        wordsOnFace = GetColliders().Count;
        if (wordsOnFace == 0)
        {
            isHeadEmpty = true;
        }
    }

    IEnumerator waitSeconds()
    {
        wordsOnFace = 7;
        yield return new WaitForSeconds(3f);
        wordsOnFace = 7;
        startTime = true;
    }

    

   




}
