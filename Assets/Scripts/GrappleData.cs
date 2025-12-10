using UnityEngine;

[CreateAssetMenu(fileName = "GrappleData", menuName = "Scriptable Objects/GrappleData")]
public class GrappleData : ScriptableObject
{
    [field:SerializeField] public float GrappleSpeed { get; set; } = 1f;
    [field: SerializeField] public float GrappleRange { get; set; } = 6f;
}
