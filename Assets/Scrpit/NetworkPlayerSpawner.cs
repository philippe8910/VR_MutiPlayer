using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class NetworkPlayerSpawner : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject SpaenPlayerPrefab;
    [SerializeField] private GameObject Cube;

    public override void OnJoinedRoom()
    {
        SpaenPlayerPrefab = PhotonNetwork.Instantiate("Network Player", transform.position, transform.rotation);
        base.OnJoinedRoom();
    }

    public override void OnLeftRoom()
    {
        PhotonNetwork.Destroy(SpaenPlayerPrefab);
        base.OnLeftRoom();
    }
    
    
}
