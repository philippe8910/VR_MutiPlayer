using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class NetworkPlayerSpawner : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject SpaenPlayerPrefab;
    [SerializeField] private Transform[] pos;

    public override void OnJoinedRoom()
    {
        Debug.Log(PhotonNetwork.CountOfPlayers);
        
        if (PhotonNetwork.CountOfPlayers == 1)
        {
            SpaenPlayerPrefab = PhotonNetwork.Instantiate("Network Player", pos[0].position, transform.rotation);
        }
        else
        {
            SpaenPlayerPrefab = PhotonNetwork.Instantiate("Network Player", pos[1].position, transform.rotation);
        }
        
        
        base.OnJoinedRoom();
    }

    public override void OnLeftRoom()
    {
        PhotonNetwork.Destroy(SpaenPlayerPrefab);
        base.OnLeftRoom();
    }
}
