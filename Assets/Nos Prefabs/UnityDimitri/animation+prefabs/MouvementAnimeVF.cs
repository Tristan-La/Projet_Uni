using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouvementAnimeVF : MonoBehaviour
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
    public float dashSpeed = 3.0f;
    public float dashStoppingSpeed = 0.1f;

    private float currentDashTime;

    private Animator animator;




    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

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
        if (transform.name != "Tucano") { 
             if (Input.GetKey(moveFront) && Input.GetKey(KeyCode.LeftShift))
        {
            desactive();
            transform.Translate(new Vector3(0, 0, (walkSpeed * 2) * Time.deltaTime));
            animator.SetBool("run", true);

        }

             if ((Input.GetKey(moveFront) && Input.GetKey(KeyCode.LeftShift)) || (!Input.GetKey(moveLeft) && !Input.GetKey(moveFront)))
        {
            animator.SetBool("walk", false);

        }
             if (!Input.GetKey(moveBack))
        {
            animator.SetBool("move back", false);

        }
             if (!Input.GetKeyDown(KeyCode.A) && !(Input.GetKey(moveFront) && Input.GetKey(KeyCode.LeftShift)))
        {
            animator.SetBool("run", false);

        }


             if (Input.GetKey(moveFront) && !(Input.GetKey(KeyCode.LeftShift)))
        {
            desactive();
            transform.Translate(new Vector3(0, 0, walkSpeed * Time.deltaTime));
            animator.SetBool("walk", true);

        }

             if (Input.GetKey(moveBack))
        {
            desactive();
            transform.Translate(new Vector3(0, 0, -(walkSpeed * Time.deltaTime)));
            animator.SetBool("move back", true);

        }

             if (Input.GetKey(moveLeft) && Input.GetKey(moveFront))
        {
            desactive();
            transform.Rotate(new Vector3(0, -(rotationSpeed / 2 * Time.deltaTime), 0));
            animator.SetBool("walk", true);

        }
             else if (Input.GetKey(moveLeft))
        {
            desactive();
            transform.Rotate(new Vector3(0, -(rotationSpeed / 2 * Time.deltaTime), 0));
            transform.Translate(new Vector3(walkSpeed / 4 * Time.deltaTime, 0, walkSpeed / 4 * Time.deltaTime));
            animator.SetBool("walk", true);

        }

             if (Input.GetKey(moveRight) && Input.GetKey(moveFront))
        {
            desactive();
            transform.Rotate(new Vector3(0, rotationSpeed / 2 * Time.deltaTime, 0));
            animator.SetBool("walk", true);

        }
             else if (Input.GetKey(moveRight))
        {
            desactive();
            transform.Rotate(new Vector3(0, rotationSpeed / 2 * Time.deltaTime, 0));
            transform.Translate(new Vector3(walkSpeed / 4 * Time.deltaTime, 0, walkSpeed / 4 * Time.deltaTime));
            animator.SetBool("walk", true);

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
            desactive();
            animator.SetBool("run", true);


            //currentDashTime = 0.0f;
        }
             if (currentDashTime < maxDashTime)
        {

            moveDirection = new Vector3(0, dashSpeed, dashSpeed);
            currentDashTime += dashStoppingSpeed;
        }
             else
        {

            moveDirection = Vector3.zero;
        }
             transform.Translate(moveDirection * Time.deltaTime);

            if (Input.GetKey(KeyCode.Mouse0))
            {
                desactive();
                animator.SetBool("attack", true);

            }
            else if (!Input.GetKey(KeyCode.Mouse0))
            {
                animator.SetBool("attack", false);

            }
        }

        if (transform.name == "Tucano")
        {

            if (Input.GetKey(KeyCode.Space) || Input.GetKey(moveFront) || Input.GetKey(moveBack) || Input.GetKey(moveLeft) || Input.GetKey(moveRight))
            {
                animator.SetBool("stationaire", false);

                if (Input.GetKey(KeyCode.Space))
                {
            desactive();
                    transform.Translate(new Vector3(0, ((walkSpeed / 2) * Time.deltaTime), ((walkSpeed / 2) * Time.deltaTime)));
                    //transform.Rotate(new Vector3( -(walkSpeed * Time.deltaTime), 0, 0));
                 animator.SetBool("decol", true);

                }
                else
                {
                    animator.SetBool("decol", false);

                }

                if (Input.GetKey(moveFront))
                {
            desactive();
                    transform.Translate(new Vector3(0, -(walkSpeed * Time.deltaTime), walkSpeed * Time.deltaTime));
                    //transform.Rotate(new Vector3( (walkSpeed * Time.deltaTime),0 , 0));
                    //animator.SetBool("stationaire", true);

                }
               

                if (Input.GetKey(moveBack))
                {
                    animator.SetBool("stationaire", true);
                }

                if (!Input.GetKey(moveFront) && !Input.GetKey(moveBack))
                {
                    animator.SetBool("stationaire", false);

                }

                if (Input.GetKey(moveLeft))
                {
            desactive();
                    transform.Translate(new Vector3((walkSpeed/4) * Time.deltaTime,0, (walkSpeed/4) * Time.deltaTime));
                    transform.Rotate(new Vector3(0, -(rotationSpeed / 2 * Time.deltaTime), 0));
                    animator.SetBool("tourne", true);

                }

                if (Input.GetKey(moveRight))
                {
            desactive();
                    transform.Translate(new Vector3((walkSpeed/4) * Time.deltaTime, 0, (walkSpeed/4) * Time.deltaTime));
                    transform.Rotate(new Vector3(0, rotationSpeed / 2 * Time.deltaTime, 0));
                    animator.SetBool("tourne", true);

                }

                if (!Input.GetKey(moveLeft)&& !Input.GetKey(moveRight))
                {
                    animator.SetBool("tourne", false);

                }
            }
            else
            {
                    animator.SetBool("decol", false);
                    animator.SetBool("stationaire", false);
                animator.SetBool("tourne", false);

                transform.Translate(new Vector3(0, -((walkSpeed / 8) * Time.deltaTime), (walkSpeed / 2) * Time.deltaTime));


            }


        }
    }

    public void desactive()
    {
        foreach(UnityEngine.AnimatorControllerParameter parametre in animator.parameters)
        {
            animator.SetBool(parametre.ToString(), false);
        }
    }
}
    

