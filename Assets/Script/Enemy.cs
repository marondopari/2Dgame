using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // 衝突した相手にPlayerタグが付いているとき
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);    //enemy削除
            Debug.Log("atatta");
        }
    }
}
