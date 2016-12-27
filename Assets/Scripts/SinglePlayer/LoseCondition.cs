using UnityEngine;
using System.Collections;

public class LoseCondition : MonoBehaviour {

    [SerializeField]
    private GameObject LoseScreen;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(coll.gameObject);
            Time.timeScale = 0.001f;
            LoseScreen.SetActive(true);
        }
    }
}
