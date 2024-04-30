using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation.Samples;

public class RotateButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private int _direction;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        GameObject spawnedObject = PlaceOnPlane.Instance.spawnedObject;
        spawnedObject.transform.Rotate(0f, 5f * _direction, 0f, Space.World);
    }
}
