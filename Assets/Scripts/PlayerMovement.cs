using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public CharacterController character;
    public GameObject bulletPrefab;

    public float movementSpeed;
    public float mouseSensitivity;
    public Transform bulletSpawnLocation;

    public float baseImpulseForce = 100f;

    private Camera cam;
    private float xRotation;
    private Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;//get main camera
        Cursor.lockState = CursorLockMode.Locked;//lock cursor to screen
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bulletPrefab, bulletSpawnLocation.position, transform.rotation * bulletPrefab.transform.rotation).GetComponent<Rigidbody>().AddForce(transform.forward * baseImpulseForce, ForceMode.Impulse);
        }






         move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //mouselook
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        if (Input.GetKey(KeyCode.Space)){
            move = player.transform.up;
        }
        
        if (Input.GetKey(KeyCode.LeftShift)){
            move = -player.transform.up;
        }

        cam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);//Y Axis
        transform.Rotate(Vector3.up * mouseX);//X Axis
    }

    private void FixedUpdate()
    {
        transform.Translate(move * Time.deltaTime * movementSpeed);
    }
}
