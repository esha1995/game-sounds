using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour
{
    public Transform movement;
    public float xpos;
    public float ypos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            xpos++;
            TransformExtentions.SetX(movement, xpos);
        }
        if (Input.GetKeyDown("a"))
        {
            xpos--;
            TransformExtentions.SetX(movement, xpos);
        }
        if (Input.GetKeyDown("w"))
        {
            ypos++;
            TransformExtentions.SetY(movement, ypos);
        }
        if (Input.GetKeyDown("s"))
        {
            ypos--;
            TransformExtentions.SetY(movement, ypos);
        }
    }

}

public static class TransformExtentions
{
    public static void SetX(this Transform transform, float x)
    {
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
    public static void SetY(this Transform transform, float y)
    {
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}
