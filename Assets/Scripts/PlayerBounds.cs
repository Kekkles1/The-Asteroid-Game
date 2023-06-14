using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    private Camera mainCamera;
    private float cameraWidth;
    private float cameraHeight;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        CalculateCameraDimensions();
    }

    // Update is called once per frame
    void Update()
    {
        WrapObject();
    }
    private void CalculateCameraDimensions()
    {
        cameraHeight = 2f * mainCamera.orthographicSize;
        cameraWidth = cameraHeight * mainCamera.aspect;
    }
    private void WrapObject()
    {
        Vector3 newPosition = transform.position;
        Vector3 viewPos = mainCamera.WorldToViewportPoint(transform.position);

        if (viewPos.x < 0)
        {
            newPosition.x += cameraWidth;
        }
        else if (viewPos.x > 1)
        {
            newPosition.x -= cameraWidth;
        }

        if (viewPos.y < 0)
        {
            newPosition.y += cameraHeight;
        }
        else if (viewPos.y > 1)
        {
            newPosition.y -= cameraHeight;
        }

        transform.position = newPosition;
    }
}
