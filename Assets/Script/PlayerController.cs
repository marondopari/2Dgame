using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;        //�v���C���[�̈ړ����x

    void Start()
    {
    }

    void Update()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime,Input.GetAxisRaw("Vertical") * speed * Time.deltaTime);     //�v���C���[���㉺���E����������
    }
}
