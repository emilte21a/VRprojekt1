using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
public class InteractionController : MonoBehaviour
{

    [SerializeField]
    GameObject bulletPrefab;

    

    // Start is called before the first frame update
    void Start()
    {
        ActionBasedController controller = GetComponent<ActionBasedController>();

        controller.activateAction.action.started += OnTrigger;
        Cursor.visible = false; 
        Cursor.lockState = CursorLockMode.Locked;
    }


    void OnTrigger(InputAction.CallbackContext ctx){
        Debug.Log("bang");
        Instantiate(bulletPrefab, transform.position,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
