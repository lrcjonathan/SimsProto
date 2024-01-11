using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class UI_ShopPanel : MonoBehaviour
{
    [SerializeField] private HorizontalLayoutGroup grid;
    [SerializeField] private UI_FurnitureRect furnitureRectPrefab;
    
    private List<FurnitureModel> allFurnitures;
    
    private void Awake()
    {
        allFurnitures = Resources.LoadAll<FurnitureModel>("Furnitures").ToList();
        CreateFurnitureRects();
    }

    private void CreateFurnitureRects()
    {
        foreach (FurnitureModel model in allFurnitures)
        {
            UI_FurnitureRect rect = Instantiate(furnitureRectPrefab);
            rect.Init(model);
            AddToGrid(rect);
        }
    }

    private void AddToGrid(UI_FurnitureRect rect)
    {
        rect.transform.SetParent(grid.transform);
    }
}
