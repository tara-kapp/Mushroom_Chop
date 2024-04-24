using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class knife : systemScoring
{
    public SpriteRenderer spriteRenderer;
    public PolygonCollider2D polygonCollider;

    public Sprite arrowSprite;
    public Sprite knifeSprite;

    public GameObject hitVFX;
    public Camera visionBlur;

    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(cursorPos.x, cursorPos.y);
        
        if (Input.GetMouseButtonDown(0)) {
            spriteRenderer.sprite = arrowSprite;
            polygonCollider.isTrigger = true;
        }
        if (Input.GetMouseButtonUp(0)) {
            spriteRenderer.sprite = knifeSprite;
            polygonCollider.isTrigger = false;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "edible")
        {
            gameObject.GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
            GameObject boomFX = Instantiate(hitVFX, other.gameObject.transform.position, Quaternion.identity);
            StartCoroutine(DestroyVFX(boomFX));
            AddScore();
        }
        else if (other.gameObject.tag == "inedible")
        {
            gameObject.GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
            GameObject boomFX = Instantiate(hitVFX, other.gameObject.transform.position, Quaternion.identity);
            StartCoroutine(DestroyVFX(boomFX));
            RemoveHealth();
        }
        else if (other.gameObject.tag == "hallucigenic")
        {
            gameObject.GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
            GameObject boomFX = Instantiate(hitVFX, other.gameObject.transform.position, Quaternion.identity);
            StartCoroutine(DestroyVFX(boomFX));
            Camera cameraFX = Instantiate(visionBlur);
            StartCoroutine(ReturnVision(cameraFX));
        }


        IEnumerator DestroyVFX(GameObject theEffect)
        {
            yield return new WaitForSeconds(.5f);
            Destroy(theEffect);
            gameObject.GetComponent<AudioSource>().Stop();
        }

        IEnumerator ReturnVision(Camera theCamera)
        {
            yield return new WaitForSeconds(2f);
            Destroy(theCamera);
        }
    }
}
