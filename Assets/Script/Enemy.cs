using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // �Փ˂��������Player�^�O���t���Ă���Ƃ�
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);    //enemy�폜
            Debug.Log("atatta");
        }
    }
}
