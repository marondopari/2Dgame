using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;        //�v���C���[�̈ړ����x
    public float xMovebleRange = 6.5f;       //�v���C���[��X�����ړ��͈�
    public float yMovebleRange = 3.5f;       //�v���C���[��Y�����ړ��͈�

    void Start()
    {
    }

    void Update()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime,Input.GetAxisRaw("Vertical") * speed * Time.deltaTime);     //�v���C���[���㉺���E����������

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xMovebleRange, xMovebleRange), Mathf.Clamp(transform.position.y, -yMovebleRange, yMovebleRange));     //�ړ��͈͂𐧌����鏈��

    }
}
