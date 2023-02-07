using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball2 : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //Rigitbodyコンポネントの取得
        rb.velocity = Vector3.right * 20f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            // rb.AddForce(Vector3.up * 200f, ForceMode.Acceleration); //Acceleration:力の与え方を徐々に行う。
            rb.velocity=Vector3.up *speed; //Rogidbodyのvelocityフィールドに代入
        }
    }
}

