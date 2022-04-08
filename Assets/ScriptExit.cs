using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptExit : MonoBehaviour
{
    public Canvas start;
    public Button exit;

    public void Click_Exit() {
        Application.Quit();
    }
}
