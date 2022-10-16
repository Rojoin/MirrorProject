using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Word : MonoBehaviour
{
    [SerializeField] private Collider2D cl;
    public bool IsMouseOver = false;
    private float z;
    private Vector2 difference = Vector2.zero;

    void Start()
    {
        cl = GetComponent<Collider2D>();
        z = transform.position.z;
    }

    private void OnMouseDown()
    {
        difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
        Debug.Log(difference);
    }

    private void OnMouseDrag()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
    }


    void Update()

    {
        transform.position = new Vector3(transform.position.x, transform.position.y, z);
    }
}
