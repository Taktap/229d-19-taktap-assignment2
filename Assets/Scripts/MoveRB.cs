using UnityEngine;

public class MoveRB : MonoBehaviour
{
    public float speed = 10f; // สามารถปรับค่าความเร็วได้จาก Inspector
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // ดึงคอมโพเนนต์ Rigidbody
    }

    void FixedUpdate()
    {
        // ใช้ Input.GetAxis สำหรับการเคลื่อนที่ด้วยปุ่ม WASD หรือ Arrow Keys
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // ใช้ Rigidbody เพื่อเคลื่อนที่
        rb.AddForce(movement * speed);
    }
}