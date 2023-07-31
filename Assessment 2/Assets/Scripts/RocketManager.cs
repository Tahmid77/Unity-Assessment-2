using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketManager : MonoBehaviour
{
    public GameObject rocket;
    public float value;
    public Vector3 sizeChange;

    public void MoveLeft()
    {
        value = value - 0.1f;
        rocket.transform.position = new Vector3(value, 0, 0);
    }
     public void MoveRight()
    {
        value = value + 0.1f;
        rocket.transform.position = new Vector3(value, 0, 0);

    }

    public void MoveUp()
    {
        value = value + 0.1f;
        rocket.transform.position = new Vector3(0, value, 0);

    }

    public void MoveDown()
    {
        value = value - 0.1f;
        rocket.transform.position = new Vector3(0, value, 0);
    }
    public void Rotateleft()
    {
        rocket.transform.Rotate(0f, 0f, 20f);
    }

    public void Grow()
    {
        rocket.transform.localScale = rocket.transform.localScale + sizeChange;
    }

    public void ResetRocket()
    {
        rocket.transform.position = new Vector3(0, 0, 0);
        rocket.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        rocket.transform.localScale = new Vector3(1, 1, 1);

    }

}
