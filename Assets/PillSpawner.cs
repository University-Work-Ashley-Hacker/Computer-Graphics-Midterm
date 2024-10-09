using UnityEngine;
using Random = System.Random;

public class PillSpawner : MonoBehaviour
{
    [SerializeField] Pill _pillObject;

    [SerializeField] Material[] _pillMaterials;

    [SerializeField] float _moveSpeed;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var pill = Instantiate(_pillObject);
            pill.transform.position = transform.position;
            pill.transform.rotation = transform.rotation;

            var rand1 = UnityEngine.Random.Range(0, _pillMaterials.Length);
            var rand2 = UnityEngine.Random.Range(0, _pillMaterials.Length);
            
            pill.SetColors(_pillMaterials[rand1], _pillMaterials[rand2]);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * _moveSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _moveSpeed);
        }
        
    }
}
