using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    public float hAxis;
    public float vAxis;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        hAxis = Input.GetAxis("Horizontal");
        vAxis = Input.GetAxis("Vertical");

        transform.position += new Vector3(hAxis * speed * Time.deltaTime, 0f, vAxis * speed * Time.deltaTime);
    }
}
