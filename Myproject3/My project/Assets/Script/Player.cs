using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Player : MonoBehaviour
{
    public float moveSpeed = 2f;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // 获取输入
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        // 计算移动方向
        Vector3 movement = new Vector3(horizontal, 0f, vertical) * moveSpeed ;

        // 应用移动
        //rb.MovePosition(transform.position + movement);

        // 将移动方向作为力添加到刚体上
        rb.AddForce(movement);
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //collision.collider.tag;
        if(collision.gameObject.tag == "Food")
        {
            Destroy(collision.gameObject);
        }
    }
}
