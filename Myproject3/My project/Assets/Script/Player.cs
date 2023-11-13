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
        // ��ȡ����
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        // �����ƶ�����
        Vector3 movement = new Vector3(horizontal, 0f, vertical) * moveSpeed ;

        // Ӧ���ƶ�
        //rb.MovePosition(transform.position + movement);

        // ���ƶ�������Ϊ����ӵ�������
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
