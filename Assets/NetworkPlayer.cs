﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class NetworkPlayer : MonoBehaviour
{
    public Transform Head;

    public Transform LeftHand;

    public Transform RightHand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MapPosition(Head , XRNode.Head);
        MapPosition(LeftHand , XRNode.LeftHand);
        MapPosition(RightHand , XRNode.RightHand);
    }

    private void MapPosition(Transform target , XRNode node)
    {
        InputDevices.GetDeviceAtXRNode(node).TryGetFeatureValue(CommonUsages.devicePosition, out Vector3 position);
        InputDevices.GetDeviceAtXRNode(node).TryGetFeatureValue(CommonUsages.deviceRotation, out Quaternion rotation);

        target.position = position;
        target.rotation = rotation;
    }
}
