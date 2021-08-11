using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    
    public GameObject red;
    public GameObject blue;

    private Vector3 Min;
    private  Vector3 Max;

    private  float _xAxis;
    private  float _yAxis;
    private  float _zAxis;

    int count = 6;
    public GameObject menu;

    void Start()
    {
         Min = new Vector3(-1.5f, -1f, -4f); 
         Max = new Vector3(1.5f, 3f, -2f);   

         SpawnRed(red);
         SpawnRed(red);
         SpawnRed(red);

         SpawnRed(blue);
         SpawnRed(blue);
         SpawnRed(blue);
        

    }

    void SpawnRed(GameObject go)
    {
        _xAxis = Random.Range(Min.x, Max.x);
        _yAxis = Random.Range(Min.y, Max.y);
        _zAxis = Random.Range(Min.z, Max.z);
        Vector3 _randomPosition = new Vector3(_xAxis, _yAxis, _zAxis );
        Instantiate(go, _randomPosition, Quaternion.identity);

    }

    public void Count_Cube()
    {
        count--;
        if(count == 0)
        {
            menu.SetActive(true);

        }
    }

    public void Reload_Scene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
