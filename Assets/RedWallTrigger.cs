using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedWallTrigger : MonoBehaviour
{
    
    Text Text;
    int count = 0;

    public Game_Manager Game_Manager;

    void Start()
    {
        Text = GameObject.Find("TextRed").GetComponent<Text>();
        Text.text = count.ToString();
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("red"))
        {
            /* Move Move = GameObject.FindWithTag("MainCamera").GetComponent<Move>();
            if(Move.isSelectedRigidbody() == null)
            return; */

            Destroy(collision.gameObject);
            count++;
            Text.text = count.ToString();
            Game_Manager.Count_Cube();
        }
        if(collision.gameObject.CompareTag("blue"))
        {
            GameObject.FindWithTag("MainCamera").GetComponent<Move>().SelectedRigidbody();
            collision.rigidbody.AddForce(Vector3.left * 100.0f);
        }
    }
}
