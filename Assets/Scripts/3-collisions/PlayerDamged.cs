using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamged : MonoBehaviour
{
    [SerializeField]
    string trigerTag;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == trigerTag && enabled)
        {
            GameObject lifeObject = GameObject.FindGameObjectWithTag("Lifes");
            if (lifeObject)
            {
                NumberField nf = lifeObject.GetComponent<NumberField>();
                Destroy(collision.gameObject);
                nf.DecreaseLife();
            }
        }
    }
}
