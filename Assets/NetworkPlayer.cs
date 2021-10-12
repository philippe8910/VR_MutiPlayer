using System.Collections;
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
    
    public GameObject NetWork_Head_Mesh;

    public GameObject NetWork_LeftHand_Mesh;

    public GameObject NetWork_RightHand_Mesh;

    public PhotonView _Photon; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Local_Head == null)
        {
            //Local_Head = GameObject.Find("VRCamera");
        }

        if (Local_LeftHand == null)
        {
            //Local_LeftHand = GameObject.Find("RightHand");
        }

        if (Local_RightHand == null)
        {
            //Local_RightHand = GameObject.Find("LeftHand");
        }


        if (_Photon.IsMine)
        {
            NetWork_Head_Mesh.gameObject.SetActive(false);
            NetWork_LeftHand_Mesh.gameObject.SetActive(false);
            NetWork_RightHand_Mesh.gameObject.SetActive(false);
        }
        
        NetWork_Head.transform.position = Local_Head.transform.position;
        NetWork_Head.transform.localRotation = Local_Head.transform.localRotation;
        
        NetWork_LeftHand.transform.position = Local_LeftHand.transform.position;
        NetWork_LeftHand.transform.localRotation = Local_LeftHand.transform.localRotation;
        
        NetWork_RightHand.transform.position = Local_RightHand.transform.position;
        NetWork_RightHand.transform.localRotation = Local_RightHand.transform.localRotation;
        
    }


}
