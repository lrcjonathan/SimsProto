using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FurnitureCategory
{
    Misc,
    Kitchen,
    LivingRoom,
    Bedroom,
    Bathroom,
    Garden,
}

[CreateAssetMenu(menuName = "Furniture", fileName = "New Furniture")]
public class FurnitureModel : ScriptableObject
{
    public int ID;
    public string Name;
    public Furniture Prefab;
    public int Price;
    public FurnitureCategory Category;

    public Furniture Generate()
    {
        Furniture obj = Instantiate(Prefab);
        obj.Init(this);
        return obj;
    }
}
