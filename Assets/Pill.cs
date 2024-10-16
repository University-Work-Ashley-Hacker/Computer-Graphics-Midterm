using UnityEngine;

public class Pill : MonoBehaviour
{
    MeshRenderer _mr;
    [SerializeField] Material _outline;
    
    void Awake() => _mr = GetComponent<MeshRenderer>();
    
    public void SetColors(Material col0, Material col1)
    {
        var materials = _mr.materials;
        materials[0] = col0;
        materials[1] = col1;
        materials[2] = _outline;
        _mr.materials = materials;
    }
}
