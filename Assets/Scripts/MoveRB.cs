using UnityEngine;

public class MoveRB : MonoBehaviour
{
    public Rigidbody rb;
    public float enginePowerThrust, liftBooster, drag, angularDrag;

    void FixedUpdate()
    {
        // 1. Add Thrust
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.forward * enginePowerThrust);
        }

        // 2. Lift
        Vector3 lift = Vector3.Project(rb.velocity, transform.forward);
        rb.AddForce(transform.up * lift.magnitude * liftBooster);

        // 3. Drag
        rb.drag = rb.velocity.magnitude * drag;
        rb.angularDrag = rb.velocity.magnitude * angularDrag;

        // 4. Control
        // 4.1. Left-Right
        rb.AddTorque(Input.GetAxis("Horizontal") * transform.forward * -1);

        // 4.2. Up-Down
        rb.AddTorque(Input.GetAxis("Vertical") * transform.forward * -1);
    }
}

/*
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
*/