using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject objectBeingDragged;
    Vector2 startPos;
    Transform startParent;

    public void OnBeginDrag(PointerEventData eventData)
    {
        objectBeingDragged = gameObject;
        startPos = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        throw new System.NotImplementedException();
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        throw new System.NotImplementedException();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        objectBeingDragged = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (startParent == transform.parent)
        {
            transform.position = startPos;
        } else
        {
        }

        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
