using UnityEngine;
using System.Collections;

public class WinCondition : MonoBehaviour
{

    [SerializeField]
    private GameObject WinScreen1;

    [SerializeField]
    private GameObject WinScreen2;

    private Pickup pickups1;

    private Pickup pickups2;

    private bool winner1;

    private bool winner2;

    void Start() {

    }

    void Update() {
        winner1 = GameObject.Find("Player1").GetComponent<Pickup>().winner;
        winner2 = GameObject.Find("Player2").GetComponent<Pickup>().winner;

        if (winner1)
        {
            Time.timeScale = 0.001f;
            WinScreen1.SetActive(true);
        }
        else
        {
            if (winner2) {
                Time.timeScale = 0.001f;
                WinScreen2.SetActive(true);
            }
        }
    }


}
