using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger game over")]
    [SerializeField] string triggeringTag;
    [SerializeField] int gameOver;

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject lifes = GameObject.FindGameObjectWithTag("Lifes");
        if (lifes)
        {
            NumberField nf = lifes.GetComponent<NumberField>();
            if (other.tag == triggeringTag && enabled && nf.GetNumber() == gameOver)
            {
                Debug.Log("Game over!");
                Application.Quit();
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #endif
            }
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }

}
