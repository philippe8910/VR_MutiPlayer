using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class PlayerManagermemt : MonoBehaviour
{
    [Tooltip("The local player instance. Use this to know if the local player is represented in the Scene")]
    public static PlayerManagermemt LocalPlayerInstance;

    [SerializeField] public GameObject RightHand;

    [SerializeField] public GameObject LeftHand;

    [SerializeField] public GameObject HeadHand;

    public PhotonView photonView;

    private void Awake()
    {
        if (photonView.IsMine)
        {
            PlayerManagermemt.LocalPlayerInstance = this;
        }
// #Critical
// we flag as don't destroy on load so that instance survives level synchronization, thus giving a seamless experience when levels load.
        DontDestroyOnLoad(this.gameObject);
    }
    
}
