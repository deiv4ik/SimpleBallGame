    using UnityEngine;
    using System;
    using UnityEditor;


    public class Bascics : MonoBehaviour
    {
        public GameObject[] objs = new GameObject[3];
        public Transform pos;
        public Light _light;

        public Transform[] tranforms = new Transform[3];
        public float speed = 5f, rotateSpeed = 10f;


        void Start()
        {
            //obj.SetActive(false);
            //obj.GetComponent<Transform>().position = new Vector3(10, 0, 5);
            // _light.intensity = 0.5f;

            // for (int i = 0; i < objs.Length; ++i)
            // {
            //     objs[i].SetActive(false);
            // }
        }

        void Update()
        {
        for (int i = 0; i < tranforms.Length; ++i)
        {
            if (tranforms[i] != null)
            {
                tranforms[i].Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
                tranforms[i].Rotate(new Vector3(-1, 0, 0) * rotateSpeed * Time.deltaTime);
            }

            float posX = tranforms[i].position.x;
            if (posX < -10f)
            {
                Destroy(tranforms[i].gameObject);
            }
            }
        }
    }
