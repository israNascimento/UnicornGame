using UnityEngine;
using System.Collections;

public class CollisionDetect : MonoBehaviour 
{
    Paint paint;
    ParticleSystem particle;
    void Start()
    {
        paint = GameObject.Find("GameManager").GetComponent<Paint>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Paint"))
        {
            int index = collision.gameObject.name.IndexOf('_');
            particle = collision.gameObject.GetComponent<ParticleSystem>();
            particle.Play();
            string color = collision.gameObject.name.Remove(index);
            collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            paint.PaintObject(color);
        }

        if (collision.gameObject.name.Contains("Airplane"))
        {
            Application.LoadLevel(1);
        }
    }
}
