using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public static int scoreCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.LeftArrow))
       {
         transform.position += transform.TransformDirection(Vector3.left*3.0f*Time.deltaTime);
       }
       
        if(Input.GetKey(KeyCode.RightArrow))
       {
         transform.position += transform.TransformDirection(Vector3.right*3.0f*Time.deltaTime);
       }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Stage1Goal"))
        {
           // Debug.Log("ステージ１のゴールを通過したよ");
           SceneManager.LoadScene("Stage2");   //stage2のSceneに遷移する
        }
        if (other.CompareTag("Stage2Goal"))
        {

          SceneManager.LoadScene("Stage3");   //stage3のSceneに遷移する
        }
        if (other.CompareTag("Item"))
        {
          scoreCount++;
          Destroy(other.gameObject);
        }
        if (other.CompareTag("MissItem"))
        {
           scoreCount = scoreCount - 3;
           Destroy(other.gameObject);
        }
    }

}

