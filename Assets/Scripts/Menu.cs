﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public void StartGame() {
        SceneManager.LoadScene(1);
    }
}
