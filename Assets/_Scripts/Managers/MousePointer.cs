using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPosition
{
    public bool Valid { get; set; } = false;
    public Vector3 Value { get; set; } = Vector3.zero;

    public MapPosition(bool valid, Vector3 value)
    {
        Valid = valid;
        Value = value;
    }
}

public class MousePointer : Singleton<MousePointer>
{
    [SerializeField] private bool debugWorldPos;
    [SerializeField] private bool debugGridPos;
    [SerializeField] private LayerMask validLayers;

    [SerializeField] private Furniture selectedFurniture;

    public MapPosition WorldPosition { get; private set; } = new MapPosition(false, Vector3.zero);
    public MapPosition WorldPositionOnGrid { get; private set; } = new MapPosition(false, Vector3.zero);

    public bool IsPositionValid => WorldPosition.Valid && !WorldGrid.Instance.IsOccupied(WorldPosition.Value);

    private void Start()
    {
        InputReader.Instance.OnLeftClick += HandleLeftClick;
        InputReader.Instance.OnRightClick += RotateSelectedFurniture;
        InputReader.Instance.OnEscapeKey += CancelSelection;
        InputReader.Instance.OnShopKey += UIManager.Instance.ToggleShopPanel;
    }

    private void OnDestroy()
    {
        InputReader.Instance.OnLeftClick -= HandleLeftClick;
        InputReader.Instance.OnRightClick -= RotateSelectedFurniture;
        InputReader.Instance.OnEscapeKey -= CancelSelection;
        InputReader.Instance.OnShopKey -= UIManager.Instance.ToggleShopPanel;
    }

    private void Update()
    {
        UpdatePositions();
    }

    private void UpdatePositions()
    {
        if (GameCamera.Instance.RaycastMousePosition(out RaycastHit hitInfo, validLayers))
        {
            WorldPosition.Valid = true;
            WorldPosition.Value = hitInfo.point;
            WorldPositionOnGrid.Valid = true;
            WorldPositionOnGrid.Value = WorldGrid.Instance.SnapToGrid(WorldPosition.Value);
        }
        else
        {
            WorldPosition.Valid = false;
            WorldPositionOnGrid.Valid = false;
        }
    }
    
    public void SelectFurniture(Furniture obj)
    {
        if (!obj) return;
        if (selectedFurniture)
        {
            Destroy(selectedFurniture.gameObject);
        }
        selectedFurniture = obj;
        selectedFurniture.PickUp();
    }

    private void TryPlaceFurniture()
    {
        if (!selectedFurniture) return;
        if (IsPositionValid)
        {
            selectedFurniture.PlaceAt(WorldPositionOnGrid.Value);
            Furniture keepAfterPlace = selectedFurniture.Model.Generate();
            keepAfterPlace.transform.rotation = selectedFurniture.transform.rotation;
            selectedFurniture = null;
            SelectFurniture(keepAfterPlace);
        }
    }

    public void CancelSelection()
    {
        if (!selectedFurniture) return;
        Destroy(selectedFurniture.gameObject);
    }
    
    private void HandleLeftClick()
    {
        if (UIManager.Instance.IsMouseOverUI()) return;
        if (!selectedFurniture) TrySelectFurniture();
        else TryPlaceFurniture();
    }

    private void TrySelectFurniture()
    {
        if (selectedFurniture || !WorldPosition.Valid) return;
        if (!WorldGrid.Instance.GetObjectAt(WorldPosition.Value, out Furniture obj))
            return;
        SelectFurniture(obj);
    }
    
    private void RotateSelectedFurniture()
    {
        if (!selectedFurniture) return;
        selectedFurniture.Rotate(90);
    }

    private void OnDrawGizmos()
    {
        if (!debugGridPos && !debugWorldPos) return;
        
        Color prev = Gizmos.color;
        
        // Mouse World Position
        Gizmos.color = Color.white;
        if (debugWorldPos && WorldPosition.Valid) Gizmos.DrawSphere(WorldPosition.Value, 0.1f);
        
        // Mouse Grid Position
        if (debugGridPos && WorldPositionOnGrid.Valid)
        {
            Gizmos.color = IsPositionValid ? Color.green : Color.red;
            float tileSize = WorldGrid.Instance.TileSize;
            Gizmos.DrawWireCube(
                WorldPositionOnGrid.Value + Vector3.up * tileSize / 2,
                new Vector3(tileSize, tileSize, tileSize)
            );
        }

        Gizmos.color = prev;
    }
}
