using UnityEngine;

public class Week2Demo : MonoBehaviour
{
    [Min(5)]
    public int favNum = 34;

    float randVar;

    [SerializeReference]
    GameObject followTarget;

    public SpriteRenderer sprite;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //sprite.color = Random.ColorHSV(1, 1, 1, 1, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = followTarget.transform.position;

        //GameObject newGO = Instantiate(followTarget);
        //newGO.GetComponent<SpriteRenderer>().color = Random.ColorHSV(1, 1, 1, 1, 0, 1);

        SpriteRenderer newSR = Instantiate(sprite);
        newSR.color = Random.ColorHSV(1, 1, 1, 1, 0, 1);
        newSR.transform.position = followTarget.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
