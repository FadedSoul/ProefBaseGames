using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WaitForPlay : MonoBehaviour
{
    [SerializeField]
    private GameObject intro;

    [SerializeField]
    private GameObject paused;

    public Text countdown;

    private bool pauzed = false;

    void Awake()
    {
        Time.timeScale = 0.001f;
        StartCoroutine(GetReady());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !pauzed)
        {
            Time.timeScale = 0.001f;
            pauzed = true;
            paused.SetActive(true);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape) && pauzed)
            {
                paused.SetActive(false);
                StartCoroutine("GetReady");
            }
        }
    }

    IEnumerator GetReady()
    {
        countdown.text = "5";
        yield return new WaitForSeconds(0.001f);

        countdown.text = "4";
        yield return new WaitForSeconds(0.001f);

        countdown.text = "3";
        yield return new WaitForSeconds(0.001f);

        countdown.text = "2";
        yield return new WaitForSeconds(0.001f);

        countdown.text = "1";
        yield return new WaitForSeconds(0.001f);

        countdown.text = "GO!";
        yield return new WaitForSeconds(0.001f);

        countdown.text = "";

        intro.SetActive(false);
        pauzed = false;
        Time.timeScale = 1;
    }
}