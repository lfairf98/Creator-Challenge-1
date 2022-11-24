using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class HostJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField hostInput;
    public InputField joinInput;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(hostInput.text);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
