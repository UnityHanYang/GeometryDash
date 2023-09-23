using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    private float speed = 130f;
    private bool istrue;
    GameObject collidedObject;
    Vector3 relativeContactPoint;
    Vector3 vec;
    private float time = 1.1f;
    public bool isH;
    private float t;
    public float rotationSpeed = 180f;
    public float maxRotationAngle = 180f;
    private float currentRotation = 0f;
    public Rigidbody rigid;
    float currentXVelocity = 0f;
    Vector3 newPosition;
    bool isEndDelay;
    bool isJump;
    private void Start()
    {
        instance = this;
        isH = false;
        StartCoroutine("WatchDelay");
    }
    IEnumerator WatchDelay()
    {
        if (!isEndDelay)
        {
            isJump = false;
            yield return new WaitForSeconds(1f);
            currentXVelocity = transform.position.x;
            isJump = true;
            isEndDelay = true;
        }
    }
    private void Update()
    {
        if (isEndDelay)
        {
            StopCoroutine("WatchDelay");
        }
        if (!isH)
        {
            t += Time.deltaTime;
            if (t < time && Esc.instance.istrue)
            {
                vec = new Vector3(11f * Time.deltaTime, 0f, 0f);
                transform.position += vec;
            }
        }
        if (isJump && istrue && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            istrue = false;
        }
        if (!istrue)
        {
            RotateObject();
        }
    }

    private void Jump()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 8f, 0) * speed, ForceMode.Impulse);
        newPosition = transform.position;
        newPosition.x = currentXVelocity;
        transform.position = newPosition;
    }
    private void RotateObject()
    {
        float rotationAmount = rotationSpeed * Time.deltaTime+1f;
        transform.Rotate(new Vector3(0, 0, -1f), rotationAmount);
        currentRotation += rotationAmount;
        if (currentRotation >= maxRotationAngle)
        {
            currentRotation = maxRotationAngle;
            istrue = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Light")
        {
            istrue = true;
        }
        if(other.tag == "Jumppad")
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 5f, 0) * speed, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        collidedObject = collision.gameObject;
        relativeContactPoint = collidedObject.transform.InverseTransformPoint(collision.contacts[0].point);
        
        if (collision.gameObject.tag == "Floor" || relativeContactPoint.y >= collidedObject.transform.localScale.y / 2 && collision.gameObject.tag == "Block" || 
            relativeContactPoint.y >= collidedObject.transform.localScale.y / 2 && collision.gameObject.tag == "Square")
        {
            istrue = true;
            currentRotation = 0f;
            transform.rotation = Quaternion.identity;
            newPosition = transform.position;
            newPosition.x = currentXVelocity;
        }
        else if(collision.gameObject.tag == "obstacle")
        {
            GameManager.instance.islive = false;
            this.gameObject.SetActive(false);
        }
    }
}
