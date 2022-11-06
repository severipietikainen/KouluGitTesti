using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{

    public string levelToLoad;
    public bool cleared;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.manager.GetType().GetField(levelToLoad).GetValue(GameManager.manager).ToString() == "True")
        {
            Cleared(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Cleared(bool isClear)
    {
        if(isClear == true)
        {
            cleared = true;
            GameManager.manager.GetType().GetField(levelToLoad).SetValue(GameManager.manager, true);

            transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<CircleCollider2D>().enabled = false;
        }
    }
}
