using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //floor props
    [Header("Configuração Chão")]
    public float        _chaoDestruido;
    public float        _chaoTamanho;
    public float        _chaoVelocidade;
    public GameObject   _chaoPrefab;


    [Header("Configuração Obst")]

    public float        _ObsTime;
    public GameObject   _ObsPrefab;
    public float        _ObsVelocit;


    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine("SpawObstacle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawObstacle()
    {
        yield return new WaitForSeconds(_ObsTime);

        GameObject ObjectObstacleTemp = Instantiate(_ObsPrefab);
        StartCoroutine("SpawObstacle");
    }
}
