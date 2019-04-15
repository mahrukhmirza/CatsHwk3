using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// mahrukh sameen mirza 
/// april 14,2019
/// this is spawner script
/// </summary>
public class Spawner : MonoBehaviour
{
    public GameObject myCat;
    private string furColor;
    private string furElement0;
    private int nfurElement0 = 4;
    private string furElement1;
    private int nfurElement1 = 3;
    private string furElement2;
    private string eyeColor;
    private string eyeElement0;
    private string eyeElement1;
    private string eyeElement2;
    private int size = 3;

    public void Spawn(Vector3 position)
    {
        Instantiate(myCat).transform.position = position;
    }

        public string FurElement
    {
        get
        {
            return furElement0;
        }
        set
        {
            if (furElement0 == "_GreyMat" && nfurElement0 > nfurElement1)
                furElement0 = value;
        }
    } 
    
    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // make Z position the Z position of prefab obj 
            Vector3 adjustZ = new Vector3(worldPoint.x, worldPoint.y, myCat.transform.position.z);
            Spawn(adjustZ);
        }
    }
}
