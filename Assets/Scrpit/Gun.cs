using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using  Valve.VR.InteractionSystem;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;

    [SerializeField] private Transform FirePoint;

    [SerializeField] private Interactable interactable;

    [SerializeField] private SteamVR_Action_Boolean FireAction;

    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<Interactable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (interactable.attachedToHand != null)
        {
            SteamVR_Input_Sources source = interactable.attachedToHand.handType;

            if (FireAction[source].stateDown)
            {
                Fire();
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    public void Fire()
    {
        GameObject _bullet = Instantiate(Bullet, FirePoint.position, Bullet.transform.rotation);
        _bullet.GetComponent<Rigidbody>().AddForce(FirePoint.forward * 1000 , ForceMode.Impulse);
    }
}
