using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Observer
{

    #region SINGETON IMPLEMENTATION
    private static GameManager _instance = null;
    public static GameManager Instance
    {
        get
        {
            // GM can't be found
            if(_instance == null)
            {
                // Search scene for instance
                _instance = GameObject.FindObjectOfType<GameManager>();

                if (_instance == null)
                {
                    GameObject newGameManager = new GameObject("_GameManager");
                    _instance = newGameManager.AddComponent<GameManager>();
                }
            }

            return _instance;
        }
    }

    #endregion

    public override void OnNotify(NotificationType type)
    {

    }
}
