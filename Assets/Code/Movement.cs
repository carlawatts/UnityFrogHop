using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
  public float playerSpeed = 7;
  public float rotationSpeed = 220;
  public float grav = -20f;
  public float jumpSpeed = 7;
  public float pushForce = 3.0f;

  private ControllerColliderHit contact;
    public Text p2Wins;
  CharacterController characterController;
  Vector3 moveVelocity;
  Vector3 turnVelocity;

  private bool playerGrounded = true;
  void Awake()
  {
    characterController = GetComponent<CharacterController>();
  }
  void Update()
  {

    bool wKeyDown = Input.GetKey(KeyCode.W);
    bool aKeyDown = Input.GetKey(KeyCode.A);
    bool dKeyDown = Input.GetKey(KeyCode.D);

    if (characterController.isGrounded)
    {
      int playerFor = 0;
      int playerRot = 0;

      if (wKeyDown)
      {
        playerFor = 1;
      }
      else
      {
        playerFor = 0;
      }

      if (aKeyDown)
      {
        playerRot = -1;
      }
      else if (dKeyDown)
      {
        playerRot = 1;
      }
      else
      {
        playerRot = 0;
      }

      moveVelocity = transform.forward * playerSpeed * playerFor;
      turnVelocity = transform.up * rotationSpeed * playerRot;
      playerGrounded = true;
    }
    if (Input.GetKey(KeyCode.C) && playerGrounded)
    {
      moveVelocity.y = jumpSpeed;
      playerGrounded = false;
    }
    //Adding gravity
    moveVelocity.y += grav * Time.deltaTime;
    characterController.Move(moveVelocity * Time.deltaTime);
    transform.Rotate(turnVelocity * Time.deltaTime);
  }

  void OnControllerColliderHit(ControllerColliderHit hit)
  {
    contact = hit;
    Rigidbody body = hit.collider.attachedRigidbody;
    if (body != null && !body.isKinematic)
    {
      body.velocity = hit.moveDirection * pushForce;
    }
  }

  private void OnTriggerEnter(Collider collision)
  {
    if (collision.gameObject.name == "Finish")
    {
      p2Wins.text = "Green Frog Wins!";
      Invoke("RestartLevel", 1f);
    }
  }

  private void RestartLevel()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }


}