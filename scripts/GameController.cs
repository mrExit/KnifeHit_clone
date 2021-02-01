using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject _knife;
    bool _isTarget = false;
    
    private void OnMouseDown()
    {
        
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,20f));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (!_isTarget && collision.collider.CompareTag("Target"))
        {
            _isTarget = true;
            this.gameObject.transform.SetParent(collision.transform);
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;

        } else if (collision.collider.CompareTag("Knife") && !_isTarget)
        {

            gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-10, 10), -5));
            StartCoroutine(Rotation());
        }
     
        
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {       
        Destroy(collision.gameObject);    
    }
    private IEnumerator Rotation()
    {
        gameObject.transform.Rotate(new Vector3(0, 0, 10));
        yield return null;
        yield return StartCoroutine(Rotation());
    }
}
