using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class GameCamera : Singleton<GameCamera>
{
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private float rotationSpeed = 100.0f;
    [SerializeField] private float zoomSpeed = 50.0f;

    [SerializeField] private float minZoom = 16.0f;
    [SerializeField] private float maxZoom = 4.0f;
    
    
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Transform cameraAnchor;

    [SerializeField] private CinemachineVirtualCamera parentCamera;
    [SerializeField] private Cinemachine3rdPersonFollow cameraFollowComponent;

    private void Start()
    {
        cameraFollowComponent = parentCamera.GetCinemachineComponent<Cinemachine3rdPersonFollow>();
    }

    public bool RaycastCenter(out RaycastHit hitInfo)
    {
        hitInfo = default;
        Ray _ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        bool hit = Physics.Raycast(_ray, out hitInfo, 100f, layerMask);
        if (!hit) return false;
        return true;
    }

    public bool RaycastMousePosition(out RaycastHit hitInfo, int mask = default)
    {
        hitInfo = default;
        if (mask == default) mask = layerMask;
        Vector3 mousePos = InputReader.Instance.MousePosition3D;
        Ray _ray = Camera.main.ScreenPointToRay(mousePos);
        bool hit = Physics.Raycast(_ray, out hitInfo, 100f, mask);
        if (!hit) return false;
        return true;
    }

    private void Update()
    {
        if (UIManager.Instance.IsMouseOverUI()) return;
        if (InputReader.Instance.HoldingLeft) MoveCamera();
        if (InputReader.Instance.HoldingRight) RotateCamera();
        if (InputReader.Instance.MouseScroll != 0) Zoom(InputReader.Instance.MouseScroll);
    }

    private void MoveCamera()
    {
        Transform anchor = cameraAnchor.transform;
        Vector3 position = anchor.position;
        position += anchor.forward * (-InputReader.Instance.MouseDeltaY * moveSpeed * Time.deltaTime);
        position += anchor.right * (-InputReader.Instance.MouseDeltaX * moveSpeed * Time.deltaTime);
        anchor.position = position;
    }

    private void RotateCamera()
    {
        Transform anchor = cameraAnchor.transform;
        anchor.eulerAngles += Vector3.up * (InputReader.Instance.MouseDeltaX * rotationSpeed * Time.deltaTime);
    }

    private void Zoom(float value)
    {
        value = -value * zoomSpeed * Time.deltaTime;
        if (!CanZoom(value)) return;
        cameraFollowComponent.CameraDistance += value;
    }

    private bool CanZoom(float value)
    {
        float currentDistance = cameraFollowComponent.CameraDistance;
        if (currentDistance + value > minZoom) return value < 0;
        if (currentDistance + value < maxZoom) return value > 0;
        return true;
    }
}
