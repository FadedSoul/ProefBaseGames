using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pickup : MonoBehaviour
{
    public bool winner = false;
    public Text pickUpTekst;

    private int pickedUp = 0;

    public GameObject[] pickUps;

    void Start() {
        TekstUpdate();
    }

    public int pickedUpsGrabbed
    {
        get
        {
            return pickedUp;
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "PickUp")
        {
            pickedUp = pickedUp + 1;
            Destroy(coll.gameObject);
            TekstUpdate();
        }

        if (pickedUp == 10)
        {
            winner = true;
        }
    }

    void TekstUpdate()
    {
        pickUpTekst.text = pickedUp + " Picked up" ;
    }
}