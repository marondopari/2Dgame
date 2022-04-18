using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    public float speed = 6f;        //�v���C���[�̈ړ����x
    public float xMovebleRange = 6.5f;       //�v���C���[��X�����ړ��͈�
    public float yMovebleRange = 3.5f;       //�v���C���[��Y�����ړ��͈�

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xMovebleRange, xMovebleRange), Mathf.Clamp(transform.position.y, -yMovebleRange, yMovebleRange));     //�ړ��͈͂𐧌����鏈��
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }
}
