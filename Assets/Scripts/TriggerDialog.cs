using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialog : MonoBehaviour
{

    public Transform gameManager;

    GameManager gameManagerC;

    public int index;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerC = gameManager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onTriggerEnter2D(Collider2D other)
    {
        //gameManager.OnTriggerDialog(index);
    }
}
