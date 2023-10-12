using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject gameCanvas;
    public GameObject sceneCamera;

    //public TMP_Text pingText;
    private bool Off;
    public GameObject disconUI;
    //public int playersAdded = 0;

    public List<PhotonPlayer> allPlayers = new List<PhotonPlayer>();

    private void Awake()
    {
        Off = false;
        gameCanvas.SetActive(true);
    }

    private void Update()
    {
        CheckInput();
        //pingText.text = "Ping: " + PhotonNetwork.GetPing();
    }


    private void CheckInput()
    {
        if(Off && Input.GetKeyDown(KeyCode.Escape))
        {
            disconUI.SetActive(false);
            Off = false;
        }
        else if(!Off && Input.GetKeyDown(KeyCode.Escape))
        {
            disconUI.SetActive(true);
            Off = true;
        }
    }

    public void SpawnPlayer()
    {
        //float randomValue = Random.Range(-0f, 0f);
        //playersAdded++;

        if(PhotonNetwork.room.PlayerCount == 1)
        {
            PhotonNetwork.Instantiate(playerPrefab.name, new Vector2(250, 159), Quaternion.identity, 0);
            //allPlayers.Add(PhotonNetwork.playerList[0]);
        }
        else if(PhotonNetwork.room.PlayerCount == 2)
        {
            PhotonNetwork.Instantiate(playerPrefab.name, new Vector2(250, 159), Quaternion.identity, 0);
        }
        else if(PhotonNetwork.room.PlayerCount == 3)
        {
            PhotonNetwork.Instantiate(playerPrefab.name, new Vector2(250, 0), Quaternion.identity, 0);
        }
        

        gameCanvas.SetActive(false);
        sceneCamera.SetActive(true);
    }

    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
        PhotonNetwork.LoadLevel("MainMenu");
    }

    

/*
    private void OnPhotonPlayerConnected(PhotonPlayer player)
    {
        GameObject obj = Instantiate(playerFeed, new Vector2(0, 0), Quaternion.identity);
        obj.transform.SetParent(feedGrid.transform, false);
        obj.GetComponent<TMP_Text>().text = player.name + " joined the game";
        obj.GetComponent<TMP_Text>().color = Color.green;
    }


    private void OnPhotonPlayerDisconnected(PhotonPlayer player)
    {
        GameObject obj = Instantiate(playerFeed, new Vector2(0, 0), Quaternion.identity);
        obj.transform.SetParent(feedGrid.transform, false);
        obj.GetComponent<TMP_Text>().text = player.name + " left the game";
        obj.GetComponent<TMP_Text>().color = Color.red;
    }
*/ 
}
