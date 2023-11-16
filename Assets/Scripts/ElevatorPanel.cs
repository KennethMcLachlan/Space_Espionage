using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorPanel : MonoBehaviour
{
    private Elevator _elevator;

    [SerializeField]
    private MeshRenderer _display;

    [SerializeField]
    private GameObject _text;

    private bool _inTriggerZone;

    private void Start()
    {
        _elevator = GameObject.Find("ElevatorContainer").GetComponent<Elevator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _inTriggerZone == true)
        {
            _display.material.color = Color.green;
            _text.SetActive(true);
            StartCoroutine(ElevatorPause());
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            _inTriggerZone = true;
        }
        else _inTriggerZone = false;
    }

    IEnumerator ElevatorPause()
    {
        yield return new WaitForSeconds(3);
        _elevator.ActivateElevator();
    }



    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.E) /* && Bool B == true*/)
    //    {
    //        //Bool A == true
    //    }
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    // if tag == PLayer

    //    //Bool B = true

    //    // if Bool A = true
    //    //RunCode
    //}
}
