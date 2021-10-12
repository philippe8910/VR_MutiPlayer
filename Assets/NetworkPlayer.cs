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
        
        SteamVR_Action_Pose poseActionR;
        poseActionR = SteamVR_Input.GetAction<SteamVR_Action_Pose>("Pose_right_tip");

        SteamVR_Action_Pose poseActionL;
        poseActionL = SteamVR_Input.GetAction<SteamVR_Action_Pose>("Pose_left_tip");

        if (!Local_Head)
        {
            Local_Head.transform.position = NetWork_Head.transform.position;
            Local_Head.transform.localRotation = NetWork_Head.transform.localRotation;
        }

        Local_LeftHand.transform.position = poseActionL[SteamVR_Input_Sources.LeftHand].localPosition;
        Local_LeftHand.transform.localRotation = poseActionL[SteamVR_Input_Sources.LeftHand].localRotation;

        Local_RightHand.transform.position = poseActionR[SteamVR_Input_Sources.RightHand].localPosition;
        Local_RightHand.transform.localRotation = poseActionR[SteamVR_Input_Sources.RightHand].localRotation;

    }


}
