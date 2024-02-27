using UnityEngine;

public class MoveRB : MonoBehaviour
{
    public float speed = 10f; // ����ö��Ѻ��Ҥ���������ҡ Inspector
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // �֧����๹�� Rigidbody
    }

    void FixedUpdate()
    {
        // �� Input.GetAxis ����Ѻ�������͹�����»��� WASD ���� Arrow Keys
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // �� Rigidbody ��������͹���
        rb.AddForce(movement * speed);
    }
}