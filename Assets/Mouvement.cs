using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mouvement : MonoBehaviour
{

    public string moveFront;
    public string moveBack;
    public string moveLeft;
    public string moveRight;
    public string dash;
    public float walkSpeed;
    public int rotationSpeed;
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

    //vérification touche le sol
    bool IsGrounded()
    {
        RaycastHit hit;
        return Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, rayDistance, layers);
            /*return Physics.CheckCapsule(animalColider.bounds.center, new Vector3(animalColider.bounds.center.x, animalColider.bounds.min.y -0.1f, animalColider.bounds.center.z), 0.63f);*/
    }

    // Update is called once per frame
    void Update()
    {
       





        if (Input.GetKey(moveFront))
        {
            //int direction = (int)Input.mousePosition.y;


            /*if((int)gameObject.transform.rotation.y != direction)
                transform.Rotate(new Vector3(0, rotationSpeed / 2 * Time.deltaTime, 0));*/
            /*transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 90, 0), 1 * Time.deltaTime);*/


            transform.Translate(new Vector3(0, 0, walkSpeed * Time.deltaTime));
        }

        if (Input.GetKey(moveBack))
        {
            /*for(int i = (int)gameObject.transform.rotation.y; i <= ((int)gameObject.transform.rotation.y+180);i++)
                transform.Rotate(new Vector3(0, rotationSpeed/100 * Time.deltaTime, 0));*/

            transform.Translate(new Vector3(0, 0, -(walkSpeed * Time.deltaTime)));
        }

        if (Input.GetKey(moveLeft))
        {
            transform.Rotate(new Vector3(0, -(rotationSpeed/2 * Time.deltaTime), 0));
        }

        if (Input.GetKey(moveRight))
        {
            transform.Rotate(new Vector3(0, rotationSpeed/2 * Time.deltaTime, 0));
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
