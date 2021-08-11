using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueWallTrigger : MonoBehaviour
{
    
    Text Text;
    int count = 0;

    public Game_Manager Game_Manager;

    void Start()
    {
        Text = GameObject.Find("TextBlue").GetComponent<Text>();
        Text.text = count.ToString();
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("blue"))
        {
           /*  Move Move = GameObject.FindWithTag("MainCamera").GetComponent<Move>();
            if(Move.isSelectedRigidbody() == null)
            return; */

            Destroy(collision.gameObject);
            count++;
            Text.text = count.ToString();
            Game_Manager.Count_Cube();
        }
        if(collision.gameObject.CompareTag("red"))
        {
            GameObject.FindWithTag("MainCamera").GetComponent<Move>().SelectedRigidbody();
            collision.rigidbody.AddForce(Vector3.right * 100.0f);
        }
    }
}
