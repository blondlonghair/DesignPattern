using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bridge
{
    public class ObjectPooler : MonoBehaviour
    {
        public GameObject prefab;
        public int poolSize = 10;
        public Transform trn;
        GameObject[] enemyPool;

        public static ObjectPooler instance;

        private void Awake()
        {
            instance = this;
            enemyPool = new GameObject[poolSize];
            for (int i = 0; i < poolSize; ++i)
            {
                enemyPool[i] = Instantiate(prefab, trn.position, Quaternion.identity,
                    GameObject.Find("Canvas").transform);
                enemyPool[i].name = "Enemy_" + i;
                enemyPool[i].SetActive(false);
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("fds");
                Spawn();
            }
        }

        public void Spawn()
        {
            for (int i = 0; i < poolSize; i++)
            {
                if (enemyPool[i].activeSelf == true)
                    continue;

                enemyPool[i].transform.position = trn.position;
                enemyPool[i].SetActive(true);

                break;
            }
        }
    }
}