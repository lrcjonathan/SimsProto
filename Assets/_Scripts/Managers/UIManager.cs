using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private EventSystem eventSys;
    
    public bool IsMouseOverUI()
    {
        return eventSys.IsPointerOverGameObject();
    }
    
    [SerializeField] private UI_ShopPanel shopPanel;
    public bool IsShopOpen => shopPanel.gameObject.activeInHierarchy; 
    public void ToggleShopPanel()
    {
        shopPanel.gameObject.SetActive(!shopPanel.gameObject.activeInHierarchy);
    }
}
