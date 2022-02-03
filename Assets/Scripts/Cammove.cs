using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cammove : MonoBehaviour
{
    public GameObject player;
    private void Start()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -800f);
    }
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -800f);
    }
}
