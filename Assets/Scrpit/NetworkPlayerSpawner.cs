using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class NetworkPlayerSpawner : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject SpaenPlayerPrefab;
    [SerializeField] private GameObject Cube;
    
    [SerializeField] private List<GameObject> PlayerList = new List<GameObject>();

    public override void OnJoinedRoom()
    {
        SpaenPlayerPrefab = PhotonNetwork.Instantiate("Network Player", transform.position, transform.rotation);
        PlayerList.Add(Cube);
        base.OnJoinedRoom();
    }

    public override void OnLeftRoom()
    {
        PhotonNetwork.Destroy(SpaenPlayerPrefab);
        base.OnLeftRoom();
    }
}
