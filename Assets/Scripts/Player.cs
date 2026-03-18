using UnityEngine;

public class Player : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            print("space");
        }
    }
}
