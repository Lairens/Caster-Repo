using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;

    float playerOrigin = 0;

    private void Start()
    {
        Vector2 playerStartPosition = new Vector2(playerOrigin, playerOrigin);
        PhotonNetwork.Instantiate(playerPrefab.name, playerStartPosition, Quaternion.identity);
    }
}