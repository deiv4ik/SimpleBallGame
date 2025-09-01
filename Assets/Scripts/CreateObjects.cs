using System.Collections;
using System;
using UnityEngine;

public class CreateObjects : MonoBehaviour
{
    public GameObject[] obj;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.U))
        {
            StartCoroutine(Create3dObjects(1f));
        }
    }
    private void Create()
    {
        for (int i = 0; i < 5; ++i)
        {
            Instantiate(obj[UnityEngine.Random.Range(0, obj.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(12f, -15f, 40f));
        }
    }

    private int RandomNumber()
    {
        return UnityEngine.Random.Range(0, 10);
    }

    private IEnumerator Create3dObjects(float wait)
    {
        while (true)
        {
            Instantiate(obj[UnityEngine.Random.Range(0, obj.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(12f, -15f, 40f));
            yield return new WaitForSeconds(wait);
        }
    }
}
