using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : Photon.MonoBehaviour
{
    
    public PhotonView photonView;
    public Rigidbody2D rb;
    public GameObject playerCamera;
    public SpriteRenderer sr;
    public TMP_Text PlayerUsername;

    public bool isGrounded;
    public float moveSpeed;
    public float jumpForce;

    private void Awake()
    {
        isGrounded = false;
        if(photonView.isMine)
        {
            playerCamera.SetActive(true);
            PlayerUsername.text = PhotonNetwork.playerName;
        }
        else
        {
            PlayerUsername.text = photonView.owner.name;
            PlayerUsername.color = Color.cyan;
        }
    }

    private void Update()
    {
        if(photonView.isMine)
        {
            CheckInput();
        }
    }

    private void CheckInput()
    {
        var move = new Vector3(Input.GetAxisRaw("Horizontal"), 0);
        transform.position += move * moveSpeed * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.A))
        {
            photonView.RPC("FlipTrue", PhotonTargets.AllBuffered);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            photonView.RPC("FlipFalse", PhotonTargets.AllBuffered);
        }
    }

    [PunRPC]
    private void FlipTrue()
    {
        sr.flipX = true;
    }

    [PunRPC]
    private void FlipFalse()
    {
        sr.flipX = false;
    }
}
