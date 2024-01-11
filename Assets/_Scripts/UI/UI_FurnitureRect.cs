using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_FurnitureRect : MonoBehaviour
{
    private FurnitureModel Model;
    
    [SerializeField] private Image furniturePreview;
    [SerializeField] private TextMeshProUGUI furnitureNameText;
    [SerializeField]private TextMeshProUGUI priceText;
    
    public void Init(FurnitureModel model)
    {
        Model = model;
        
        // Set furniture preview
        furnitureNameText.text = Model.Name;
        priceText.text = Model.Price.ToString();
        
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        MousePointer.Instance.SelectFurniture(Model.Generate());
    }
}
