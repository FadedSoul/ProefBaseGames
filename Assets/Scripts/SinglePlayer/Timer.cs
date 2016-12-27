using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {
    private float timer;
    public Text TimerTekst;

    void Update() {
        Displaytext();
    }

    void Displaytext()
    {
        timer += Time.deltaTime;

        TimerTekst.text = Mathf.Floor(timer).ToString();
    }
}
