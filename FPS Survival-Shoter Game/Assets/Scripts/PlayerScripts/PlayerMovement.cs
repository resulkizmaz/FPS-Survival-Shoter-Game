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
        moveDirection = new Vector3(Input.GetAxis(Axis.HORIZONTAL), 0, Input.GetAxis(Axis.VERTICAL)); // eksenlerde yazým yanlýþý yapmamak için.
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed * Time.deltaTime; // deltaTime ile çarpmamýzýn sebebi baðlý fonksiyonu update'de çaðýrdýðýmýz için smoot'luðu saðlamasýný istememiz.

        ApplyGravity();
        characterController.Move(moveDirection); // bu komut içerisinde Vector3 tutan unity takýmý tarafýndan oluþturulan bir metod.
    }// MoveThePlayer
    void ApplyGravity() // Yerçekimini kontrol edip karakteri zýplatalým.
    {



    }//ApplyGravity


}
