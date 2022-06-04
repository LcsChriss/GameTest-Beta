using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatFloor : MonoBehaviour
{
    private GameController _gameController;

    public bool _chaoinstanciado = false;

    // Start is called before the first frame update
    void Start()
    {
        _gameController = FindObjectOfType(typeof(GameController)) as GameController;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_chaoinstanciado ==  false)
            {
                if(transform.position.x <= 0)
                {
                    _chaoinstanciado = true;
                    GameObject ObjectTempFloor = Instantiate(_gameController._chaoPrefab);
                    ObjectTempFloor.transform.position = new Vector3(transform.position.x + _gameController._chaoTamanho, transform.position.y, 0);
                    Debug.Log("O Chão foi instanciado");
                }
            }

            if(transform.position.x < _gameController._chaoDestruido)
            {
                Destroy(this.gameObject);
            }
        }

    private void FixedUpdate() 
    {
        MoveFloor();
    }

    void MoveFloor()
    {
        transform.Translate(Vector2.left * _gameController._chaoVelocidade * Time.deltaTime );
    }
}
