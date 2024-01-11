using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader : Singleton<InputReader>
{
    public event Action OnLeftPress;
    public event Action OnLeftRelease;
    public event Action OnRightPress;
    public event Action OnRightRelease;
    public event Action OnLeftClick;
    public event Action OnRightClick;

    public event Action OnEscapeKey;
    public event Action OnShopKey;

    private float timeBeforeLeftRelease = 0f;
    private float timeBeforeRightRelease = 0f;
    public bool HoldingLeft { get; private set; }
    public bool HoldingRight { get; private set; }
    
    public Vector2 MousePosition2D { get; private set; }
    public Vector3 MousePosition3D { get; private set; }
    
    public float MouseDeltaX { get; private set; }
    public float MouseDeltaY { get; private set; }
    
    public float MouseScroll { get; private set; }

    private InputAsset asset;

    protected override void Awake()
    {
        base.Awake();
        asset = new InputAsset();
        AddInputListeners();
    }

    private void Update()
    {
        MousePosition2D = asset.Main.MousePosition.ReadValue<Vector2>();
        MousePosition3D = new Vector3(MousePosition2D.x, MousePosition2D.y, 0);

        MouseDeltaX = asset.Main.MouseDeltaX.ReadValue<float>();
        MouseDeltaY = asset.Main.MouseDeltaY.ReadValue<float>();

        MouseScroll = asset.Main.Zoom.ReadValue<float>();

        if (HoldingLeft) timeBeforeLeftRelease += Time.deltaTime;
        if (HoldingRight) timeBeforeRightRelease += Time.deltaTime;
    }

    private void AddInputListeners()
    {
        asset.Main.MouseLeftButton.performed += (context) => {
            if (!HoldingLeft)
            {
                OnLeftPress?.Invoke(); 
                HoldingLeft = true;
            }
            else
            {
                OnLeftRelease?.Invoke();
                if (timeBeforeLeftRelease <= 0.2f) OnLeftClick?.Invoke();
                timeBeforeLeftRelease = 0f;
                HoldingLeft = false;
            }
        };
        asset.Main.MouseRightButton.performed += (context) => {
            if (!HoldingRight)
            {
                OnRightPress?.Invoke(); 
                HoldingRight = true;
            }
            else
            {
                OnRightRelease?.Invoke(); 
                if (timeBeforeRightRelease <= 0.2f) OnRightClick?.Invoke();
                timeBeforeRightRelease = 0f;
                HoldingRight = false;
            }
        };
        asset.Main.OpenShop.performed += (context) => OnShopKey?.Invoke();
        asset.Main.Escape.performed += (context) => OnEscapeKey?.Invoke();
    }

    private void OnEnable() => asset.Enable();
    private void OnDisable() => asset.Disable();
}
