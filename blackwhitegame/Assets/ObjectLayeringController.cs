using UnityEngine;

public class ObjectLayeringController : MonoBehaviour
{
    public GameObject thisObjectsParent;
    public GameObject playerObject;

    public SpriteRenderer thisSprite;
    public SpriteRenderer playerSprite;

    // Start is called before the first frame update
    void Start()
    {
        thisSprite = GetComponent<SpriteRenderer>();
        playerSprite = playerObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(thisObjectsParent.transform.position.y <= playerObject.transform.position.y)
        {
            thisSprite.sortingOrder = playerSprite.sortingOrder + 1;
        }
        else if(thisObjectsParent.transform.position.y > playerObject.transform.position.y)
        {
            thisSprite.sortingOrder = playerSprite.sortingOrder - 1;

        }
    }
}
