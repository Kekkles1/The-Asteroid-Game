using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBounds : MonoBehaviour
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
        Destroy();
    }
    private void CalculateCameraDimensions()
    {
        cameraHeight = 2f * mainCamera.orthographicSize;
        cameraWidth = cameraHeight * mainCamera.aspect;
    }

    private void Destroy()
    {
        Vector3 newPosition = transform.position;
        Vector3 viewPos = mainCamera.WorldToViewportPoint(transform.position);

        if (viewPos.x < -1)
        {
            Destroy(gameObject);
        }
        else if (viewPos.x > 2)
        {
            Destroy(gameObject);
        }

        if (viewPos.y < -1)
        {
            Destroy(gameObject);
        }
        else if (viewPos.y > 2)
        {
            Destroy(gameObject);
        }
    }
}
