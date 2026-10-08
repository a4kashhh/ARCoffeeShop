using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARPlacementManager : MonoBehaviour
{
    public GameObject coffeeShopPrefab;

    private ARRaycastManager raycastManager;
    private GameObject spawnedCoffeeShop;

    private static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Start()
    {
        raycastManager = FindFirstObjectByType<ARRaycastManager>();
    }

    void Update()
    {
        if (Input.touchCount == 0)
            return;

        Touch touch = Input.GetTouch(0);

        if (touch.phase != TouchPhase.Began)
            return;

        if (raycastManager.Raycast(
            touch.position,
            hits,
            TrackableType.PlaneWithinPolygon))
        {
            Pose hitPose = hits[0].pose;

            if (spawnedCoffeeShop == null)
            {
                spawnedCoffeeShop = Instantiate(
                    coffeeShopPrefab,
                    hitPose.position,
                    hitPose.rotation
                );
            }
            else
            {
                spawnedCoffeeShop.transform.SetPositionAndRotation(
                    hitPose.position,
                    hitPose.rotation
                );
            }
        }
    }
}