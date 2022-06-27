using UnityEngine;


namespace RPGCharacterAnimsFREE
{
    public class GUIControls : MonoBehaviour
    {
        private bool useInstant;
        private bool instantToggle;
        private bool useNavigation;
        private Vector3 jumpInput;
        public GameObject nav;

        private void Start()
        {
        }

        private void OnGUI()
        {
        }

        private void Navigation()
        {
            useNavigation = GUI.Toggle(new Rect(610, 105, 100, 30), useNavigation, "Navigation");
            if (useNavigation)
            {
                nav.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
                nav.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().enabled = true;
                RaycastHit hit;
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
                {
                    nav.transform.position = hit.point;
                }
            }
            else
            {
            }
        }
    }
}




        // Death / Debug.
