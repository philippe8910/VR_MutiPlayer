using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.XR;
using Valve.VR;

public class NetworkPlayer : MonoBehaviourPun
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

    private SteamVR_TrackedObject trackedObj;

    public SteamVR_Input_Sources inputSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

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
