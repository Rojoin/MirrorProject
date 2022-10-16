using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class mirrorCharacter : MonoBehaviour
{
    [SerializeField] private int wordsOnFace;

    [SerializeField] private Collider2D cl;

    private HashSet<Collider2D> colliders = new HashSet<Collider2D>();
    private bool isHeadEmpty => (GetColliders().Count== 0);
    public HashSet<Collider2D> GetColliders() { return colliders; }


    void Start()
    {
        cl = GetComponentInChildren<Collider2D>();
    }

  
    void Update()
    {
      if (isHeadEmpty)
      {
          Debug.Log("Ya no sos tonto");
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

    

   




}