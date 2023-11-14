using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Player : MonoBehaviour
{
    public float moveSpeed = 2f;

    public Rigidbody rb;

    public int score = 0;

    public Text text ;

    public Text win;

    public Image gz;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        text.text = "score: 0";
        win.enabled = false;
        gz.enabled = false;
        //win.enabled(false);
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

    void OnTriggerEnter(Collider other)
    {
        //collision.collider.tag;
        if(other.gameObject.tag == "Food")
        {
            Destroy(other.gameObject);
            score++;
            text.text = "score: " + score;
            if(score == 4)
            {
                gz.enabled = true;
                win.enabled = true;
            }
        }
    }
}
