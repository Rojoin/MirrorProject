using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class mirrorCharacter : MonoBehaviour
{
    [SerializeField] private int wordsOnFace;

    [SerializeField] private Collider2D cl;
    [SerializeField] private LevelLoader ll;
    private bool startTime = false;
    private HashSet<Collider2D> colliders = new HashSet<Collider2D>();
    private bool isHeadEmpty;
    public HashSet<Collider2D> GetColliders() { return colliders; }


    void Start()
    {
        ll = FindObjectOfType<LevelLoader>();
        cl = GetComponentInChildren<Collider2D>();
        isHeadEmpty = false;
        StartCoroutine(waitSeconds());
    }

  
    void Update()
    {
      if (isHeadEmpty & startTime)
      {
          Debug.Log("Flaco porque");
          ll.LoadNextLevel();
      }

      if (GetColliders().Count == 0)
      {
          isHeadEmpty = true;
      }
 
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        colliders.Add(other); //hashset automatically handles duplicates
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        colliders.Remove(other);
    }

    IEnumerator waitSeconds()
    {
        yield return new WaitForSeconds(5f);
        startTime = true;
    }

    

   




}
