using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ControllerManager : MonoBehaviour
{
    private List<Controller> _controllers;
    // Start is called before the first frame update
    void Awake()
    {
        _controllers = FindObjectsOfType<Controller>().ToList();
        int index = 1;
        foreach(var controller in _controllers)
        {
            controller.SetIndex(index);
            index++;
        }
    }

    private void Update()
    {
        foreach(var controller in _controllers)
        {
            if (controller.IsAssigned == false && controller.AnyButtonDown())
            {
                AssignController(controller);
            }
        }
    }

    private void AssignController(Controller controller)
    {
        controller.IsAssigned = true;
        Debug.Log("assigned controller " + controller.gameObject.name);
        FindObjectOfType<PlayerManager>().AddPlayerToGame(controller);
    }
}
