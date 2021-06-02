using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//2d example 
//our one side of square of the grid    0.5
//reciprocal value of this  1/0.5 = 2
//our object'x position is 1.477
//multiply this x with reciprocal value we got   1.477*2 = 2.954
//Mathf.Round  2.954 => 3
//then what we get we divide with reciprocal value      3/2 = 1.5
//snapped!
//

[ExecuteInEditMode]
public class SnapToGridScript : MonoBehaviour {

    public float grid = 0.5f;  //greater then 0

    float x = 0f, y = 0f;//wanted position


	// Update is called once per frame
	void Update ()
    {
    	if(grid<=0f)
	{
	grid=1f;
	}//defaulting to 1
	
        if (grid > 0f)
        {
            float reciprocalGrid = 1f / grid;

            x = Mathf.Round(transform.position.x * reciprocalGrid) / reciprocalGrid;
            y = Mathf.Round(transform.position.y * reciprocalGrid) / reciprocalGrid;

            transform.position = new Vector3(x, y, transform.position.z);
        }
    }
}
