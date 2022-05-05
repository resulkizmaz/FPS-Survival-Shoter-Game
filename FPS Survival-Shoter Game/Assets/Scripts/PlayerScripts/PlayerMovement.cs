using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;
    Vector3 moveDirection;

    public float speed = 5f;
    public float jumpForce = 10f;

    float gravity = 20f;
    float verticalVelocity;
    private void Awake() // caching
    {
        characterController = GetComponent<CharacterController>(); 
    }

    void Update()
    {
        MoveThePlayer();
    }
    void MoveThePlayer() //Karatkeri hareket ettirelim
    {
        moveDirection = new Vector3(Input.GetAxis(Axis.HORIZONTAL), 0, Input.GetAxis(Axis.VERTICAL)); // eksenlerde yaz�m yanl��� yapmamak i�in.
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed * Time.deltaTime; // deltaTime ile �arpmam�z�n sebebi ba�l� fonksiyonu update'de �a��rd���m�z i�in smoot'lu�u sa�lamas�n� istememiz.

        ApplyGravity();
        characterController.Move(moveDirection); // bu komut i�erisinde Vector3 tutan unity tak�m� taraf�ndan olu�turulan bir metod.
    }// MoveThePlayer
    void ApplyGravity() // Yer�ekimini kontrol edip karakteri z�platal�m.
    {



    }//ApplyGravity


}
