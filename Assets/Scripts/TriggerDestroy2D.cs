using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDestroy2D : MonoBehaviour
{
    [SerializeField] string sceneName;

    private void OnTriggerEnter2D(Collider2D other)
    {
            SceneManager.LoadScene(sceneName);    // Input can either be a serial number or a name; here we use name.
    }

}
