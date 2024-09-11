using RNBExtensions;
using UnityEditor.Animations;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    [field: SerializeField] public float JumpForce { get; set; }
    [field: SerializeField] public float JumpSpeed { get; set; }
    [field: SerializeField] public Transform OriginPosition { get; set; }
    [field: SerializeField] public BasicEnum.JumpState JumpState { get; set; }
    [field: SerializeField] public AnimatorController Animator { get; set; }
}
