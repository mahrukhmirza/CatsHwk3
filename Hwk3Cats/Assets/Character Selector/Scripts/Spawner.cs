using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject myCat;
    private string furColor;
    private string fElement0;
    private int nfElement0 = 4;
    private string fElement1;
    private int nfElement1 = 3;
    private string fElement2;
    private string eyeColor;
    private string eElement0;
    private string eElement1;
    private string eElement2;
    private int size = 3;

    public void Spawn(Vector3 position)
    {
        Instantiate(myCat).transform.position = position;
    }

        public string FElement
    {
        get
        {
            return fElement0;
        }
        set
        {
            if (fElement0 == "_GreyMat" && nfElement0 > nfElement1)
                fElement0 = value;
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
