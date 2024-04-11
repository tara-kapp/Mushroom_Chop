using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knife : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public PolygonCollider2D polygonCollider;
    public Sprite arrowSprite;
    public Sprite knifeSprite;
    public GameObject hitVFX;

    void FixedUpdate()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(cursorPos.x, cursorPos.y);
        
        if (Input.GetMouseButtonDown(0)) {
            spriteRenderer.sprite = arrowSprite;
            //Destroy(polygonCollider);
            polygonCollider.isTrigger = true;
        }
        if (Input.GetMouseButtonUp(0)) {
            spriteRenderer.sprite = knifeSprite;
            polygonCollider.isTrigger = false;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "mushroom")
        {
            Destroy(other.gameObject);
            GameObject boomFX = Instantiate(hitVFX, other.gameObject.transform.position, Quaternion.identity);
            StartCoroutine(DestroyVFX(boomFX));


        }

        IEnumerator DestroyVFX(GameObject theEffect)
        {
            yield return new WaitForSeconds(0.2f);
            Destroy(theEffect);
            //gameObject.GetComponent<AudioSource>().Stop();
        }
    }
}
