using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Player[] _players;

    private void Awake()
    {
        _players = FindObjectsOfType<Player>();
    }

    internal void AddPlayerToGame(Controller controller)
    {
        var firstNonActivePlayer = _players
            .OrderBy(p => p.PlayerNumber)
            .FirstOrDefault(p => p.HasController == false);
        firstNonActivePlayer.InitializePlayer(controller);
    }
}
