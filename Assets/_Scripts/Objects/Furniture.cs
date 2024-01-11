using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture : MonoBehaviour
{
    public FurnitureModel Model { get; private set; }
    public bool IsHeld { get; private set; } = false;

    public MeshRenderer[] meshRenderers;
    
    private void SetTransparency(float value)
    {
        foreach (MeshRenderer rdr in meshRenderers)
        {
            Color c = rdr.material.color;
            c.a = value;
            rdr.material.color = c;
        }
    }

    public void Init(FurnitureModel model)
    {
        Model = model;
        meshRenderers = GetComponentsInChildren<MeshRenderer>();
    }

    private void Update()
    {
        if (IsHeld) transform.position = MousePointer.Instance.WorldPositionOnGrid.Value;
    }

    public void PickUp()
    {
        if (IsHeld) return;
        IsHeld = true;
        SetTransparency(0.5f);
    }

    public void Rotate(float amount)
    {
        if (!IsHeld) return;
        transform.eulerAngles += Vector3.up * amount;
    }
    
    public void PlaceAt(Vector3 pos)
    {
        if (!IsHeld) return;
        transform.position = pos;
        IsHeld = false;
        SetTransparency(1f);
    }
}
