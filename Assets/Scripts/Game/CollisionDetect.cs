using UnityEngine;
using System.Collections;

public class CollisionDetect : MonoBehaviour 
{
    Paint paint;

    void Start()
    {
        paint = GameObject.Find("GameManager").GetComponent<Paint>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Paint"))
        {
            int index = collision.gameObject.name.IndexOf('_');
            string color = collision.gameObject.name.Remove(index);
            paint.PaintObject(color);
        }
    }
}
