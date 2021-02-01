using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Object_enemy", menuName ="Enemy")]
public class ObjectScenes : ScriptableObject
{
    public new string _name;
    public GameObject _gameObject;
    public bool IsPlace(string nameObject)
    {
        if (Random.Range(0, 100) <= 90)
            return true;
        return false;
    }
  
}
