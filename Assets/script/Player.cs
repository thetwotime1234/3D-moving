using UnityEngine;
public class Player : MonoBehaviour
{
    float moveX;
    float moveZ;

    public float Speed;
    Vector3 moveVec;

    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");

        moveVec = new Vector3(moveX, 0, moveZ).normalized;
        transform.position += moveVec * Speed * Time.deltaTime;          
    }
}