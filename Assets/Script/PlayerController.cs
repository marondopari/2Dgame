using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;        //プレイヤーの移動速度
    public float xMovebleRange = 6.5f;       //プレイヤーのX方向移動範囲
    public float yMovebleRange = 3.5f;       //プレイヤーのY方向移動範囲

    void Start()
    {
    }

    void Update()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime,Input.GetAxisRaw("Vertical") * speed * Time.deltaTime);     //プレイヤーを上下左右動かす処理

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xMovebleRange, xMovebleRange), Mathf.Clamp(transform.position.y, -yMovebleRange, yMovebleRange));     //移動範囲を制限する処理

    }
}
