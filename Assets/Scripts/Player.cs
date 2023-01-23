using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _playerNumber;
    private Controller _controller;

    public bool HasController { get { return _controller != null; } }
    public int PlayerNumber { get { return _playerNumber; } }

    // Start is called before the first frame update
    public void InitializePlayer(Controller controller)
    {
        this._controller = controller;

        gameObject.name = string.Format("Player {0} - {1}", _playerNumber, controller.gameObject.name);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
