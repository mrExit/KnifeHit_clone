using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatScenes : MonoBehaviour
{
  [SerializeField] ObjectScenes _spider;
    void Start()
    {
        if (_spider.IsPlace(_spider.name))
            Instantiate(_spider._gameObject, new Vector2(0, 7f), Quaternion.identity, this.transform).transform.localPosition=(new Vector2(0,7));
    }

    
}
