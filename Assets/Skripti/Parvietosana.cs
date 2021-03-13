using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Parvietosana : MonoBehaviour, IDragHandler
{
    private RectTransform transformacija;
    public Canvas kanva;

    private void Awake()
    {
        transformacija = GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData notikums)
    {
        transformacija.anchoredPosition += notikums.delta / kanva.scaleFactor;
    }
}
