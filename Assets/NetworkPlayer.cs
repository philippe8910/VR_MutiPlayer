﻿using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.XR;

public class NetworkPlayer : MonoBehaviour
{
    public GameObject Local_Head;

    public GameObject Local_LeftHand;

    public GameObject Local_RightHand;
    
    public GameObject NetWork_Head;

    public GameObject NetWork_LeftHand;

    public GameObject NetWork_RightHand;
    
    public GameObject Mesh_Head;

    public GameObject Mesh_LeftHand;

    public GameObject Mesh_RightHand;

    public PhotonView _Photon; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (NetWork_Head == null)
        {
            NetWork_Head = PlayerManagermemt.instance.Head;
        }

        if (NetWork_RightHand == null)
        {
            NetWork_RightHand = PlayerManagermemt.instance.RightHand;
        }

        if (NetWork_LeftHand == null)
        {
            NetWork_LeftHand = PlayerManagermemt.instance.LeftHand;
        }


        if (_Photon.IsMine)
        {
            Mesh_Head.gameObject.SetActive(false);
            Mesh_LeftHand.gameObject.SetActive(false);
            Mesh_RightHand.gameObject.SetActive(false);
        }
        
        Local_Head.transform.position = NetWork_Head.transform.position;
        Local_Head.transform.localRotation = NetWork_Head.transform.localRotation;
        
        Local_LeftHand.transform.position = NetWork_LeftHand.transform.position;
        Local_LeftHand.transform.localRotation = NetWork_LeftHand.transform.localRotation;
        
        Local_RightHand.transform.position = NetWork_RightHand.transform.position;
        Local_RightHand.transform.localRotation = NetWork_RightHand.transform.localRotation;
        
    }


}
