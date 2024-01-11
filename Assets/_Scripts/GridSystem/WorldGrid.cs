using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGrid : Singleton<WorldGrid>
{
    public float TileSize = 1.0f;

    public Vector3 SnapToGrid(Vector3 worldPos)
    {
        float gridX = Mathf.Floor(worldPos.x / TileSize);
        float gridZ = Mathf.Floor(worldPos.z / TileSize);

        gridX += TileSize / 2;
        gridZ += TileSize / 2;

        return new Vector3(gridX, worldPos.y, gridZ);
    }

    /* OLD DETECTION, NOT WORKING FOR MULTIPLE OBJECTS AT THE SAME PLACE
    public bool IsOccupied(Vector3 worldPos)
    {
        Vector3 gridPos = SnapToGrid(worldPos);
        Vector3 boxExtents = new Vector3(TileSize / 2 - 0.1f, 0.1f, TileSize / 2 - 0.1f);
        if (Physics.BoxCast(gridPos - Vector3.up * 0.2f, boxExtents, Vector3.up, out RaycastHit hitInfo))
        {
            Furniture obj = hitInfo.transform.parent.GetComponent<Furniture>();
            if (!obj) return false;
            if (obj && !obj.IsHeld) return true;
        }
        return false;
    }
    */

    public bool IsOccupied(Vector3 worldPos)
    {
        Vector3 gridPos = SnapToGrid(worldPos);
        Vector3 boxExtents = new Vector3(TileSize / 2 - 0.1f, 0.1f, TileSize / 2 - 0.1f);
        RaycastHit[] results = Physics.BoxCastAll(gridPos - Vector3.up * 0.2f, boxExtents, Vector3.up);
        if (results.Length < 1) return false;
        foreach (RaycastHit hitInfo in results)
        {
            Furniture obj = hitInfo.transform.parent.GetComponent<Furniture>();
            if (!obj) continue;
            if (!obj.IsHeld) return true;
        }
        return false;
    }

    public bool GetObjectAt<T>(Vector3 worldPos, out T obj) where T : MonoBehaviour
    { 
        obj = default;
        Vector3 gridPos = SnapToGrid(worldPos);
        Vector3 boxExtents = new Vector3(TileSize / 2 - 0.1f, 0.1f, TileSize / 2 - 0.1f);
        if (Physics.BoxCast(gridPos - Vector3.up * 1f, boxExtents, Vector3.up, out RaycastHit hitInfo))
        {
            obj = hitInfo.transform.parent.GetComponent<T>();
            if (!obj)
                return false;
            if (obj is Furniture f)
                return !f.IsHeld;
            // Check other cases here if needed
            return true;
        }
        return false;
    }
}
