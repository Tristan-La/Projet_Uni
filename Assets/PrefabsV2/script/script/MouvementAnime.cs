using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouvementAnime : MonoBehaviour
{

    public string moveFront = "z";
    public string moveBack = "s";
    public string moveLeft ="q";
    public string moveRight = "d";
    public string dash = "a";
    public string run = "w";
    public float walkSpeed = 6;
    public int rotationSpeed = 200;
    public Vector3 jumpSpeed;

    [SerializeField]
    private float rayDistance;
    [SerializeField]
    private LayerMask layers;

    CapsuleCollider animalColider;

    public Vector3 moveDirection;
    public float maxDashTime = 1.0f;
    public float dashSpeed = 1.0f;
    public float dashStoppingSpeed = 0.1f;

    private float currentDashTime;



    // Start is called before the first frame update
    void Start()
    {
        animalColider = gameObject.GetComponent<CapsuleCollider>();
        currentDashTime = maxDashTime;
    }

    bool IsGrounded()
    {
        RaycastHit hit;
        return Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, rayDistance, layers);
        /*return Physics.CheckCapsule(animalColider.bounds.center, new Vector3(animalColider.bounds.center.x, animalColider.bounds.min.y -0.1f, animalColider.bounds.center.z), 0.63f);*/
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveFront) && !(Input.GetKey(KeyCode.LeftShift)))
        {
            transform.Translate(new Vector3(0, 0, walkSpeed * Time.deltaTime));
        }


            if (Input.GetKey(moveFront) && Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(new Vector3(0, 0, (walkSpeed * 2) * Time.deltaTime));
            }



            if (Input.GetKey(moveBack))
            {
                transform.Translate(new Vector3(0, 0, -(walkSpeed * Time.deltaTime)));
            }

            if (Input.GetKey(moveLeft) && Input.GetKey(moveFront))
            {
                transform.Rotate(new Vector3(0, -(rotationSpeed / 2 * Time.deltaTime), 0));
            }
            else if (Input.GetKey(moveLeft))
            {
                transform.Rotate(new Vector3(0, -(rotationSpeed / 2 * Time.deltaTime), 0));
                transform.Translate(new Vector3(walkSpeed/4 * Time.deltaTime, 0, walkSpeed/4 * Time.deltaTime));
            }

            if (Input.GetKey(moveRight) && Input.GetKey(moveFront))
            {
                transform.Rotate(new Vector3(0, rotationSpeed / 2 * Time.deltaTime, 0));
            }
            else if (Input.GetKey(moveRight))
            {
                transform.Rotate(new Vector3(0, rotationSpeed / 2 * Time.deltaTime, 0));
                transform.Translate(new Vector3(walkSpeed/4 * Time.deltaTime, 0, walkSpeed/4 * Time.deltaTime));
            }




        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            //Préparation du saut
            /*Vector3 v = gameObject.GetComponent<Rigidbody>().velocity;
            v.y = jumpSpeed.y;*/

            //Saut
            gameObject.GetComponent<Rigidbody>().velocity = jumpSpeed;
        }

        /*if (Input.GetKeyDown(dash))
        {
            transform.Translate(new Vector3(0,0, ((walkSpeed * Time.deltaTime) + 5)));
        }*/

        if (Input.GetKeyDown(KeyCode.A))
        {
            currentDashTime = 0.0f;
        }
        if (currentDashTime < maxDashTime)
        {
            moveDirection = new Vector3(0, 0, dashSpeed);
            currentDashTime += dashStoppingSpeed;
        }
        else
        {
            moveDirection = Vector3.zero;
        }
        transform.Translate(moveDirection * Time.deltaTime);
    }
}
    

