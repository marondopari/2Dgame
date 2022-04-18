using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Rigidbody2D rigid;        //リジットボディを格納するための変数
    float horizontal;
    float vertical;
    public float speed = 6f;        //プレイヤーの移動速度
    public float xMovebleRange = 6.5f;       //プレイヤーのX方向移動範囲
    public float yMovebleRange = 3.5f;       //プレイヤーのY方向移動範囲

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");       //水平方向の入力
        vertical = Input.GetAxis("Vertical");       //縦方向の入力


        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xMovebleRange, xMovebleRange), Mathf.Clamp(transform.position.y, -yMovebleRange, yMovebleRange));     //移動範囲を制限する処理
    }

    void FixedUpdate()
    {
        Vector2 position = rigid.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;      //左右移動
        position.y = position.y + speed * vertical * Time.deltaTime;        //上下移動

        rigid.MovePosition(position);
    }
    
}
