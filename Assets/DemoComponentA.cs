using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("My Components/Demo Component A")]
[RequireComponent(typeof(DemoComponentB))]
[DisallowMultipleComponent]
public class DemoComponentA : MonoBehaviour
{
    [Header("Colours")]

    [Tooltip("Tooltip for Colour 1")]
    public Color Colour1;
    [Tooltip("Tooltip for Colour 2")]
    [ColorUsage(false)] public Color Colour2;

    [Space(10)]

    [Tooltip("Tooltip for Colour 3")]
    [ColorUsage(false, true)] public Color Colour3;
    [Tooltip("Tooltip for Colour 4")]
    [ColorUsage(true, true)] public Color Colour4;

    [Header("Ranges")]
    public float Float1;
    [Range(0f, 1f)] public float Float2;

    [Header("Colours With Helpers")]
    [ContextMenuItem("Reset to White", "ResetColour5ToWhite")]
    [ContextMenuItem("Reset to Black", "ResetColour5ToBlack")]
    public Color Colour5;

    public enum ETestEnum
    {
        [InspectorName("Default")]
        Value1,
        [InspectorName("DEPRECATED - Was Value 2")]
        Value2,
        [InspectorName("Minimum")]
        Value3, 
        Value4, 
        Value5, 
        Value6
    }

    [Header("Enums")]
    public ETestEnum ETest;

    [Header("Text")]
    public string Text1;
    [TextArea] public string Text2;
    [TextArea(1, 10)] public string Text3;

    private bool TestBool1;
    [Header("Properties")]
    [SerializeField] private bool TestBool2;
    [field: SerializeField] public bool TestBool3 { get; private set; }
    [field: SerializeField, Range(0f, 1f)] public float Float3 { get; private set; }
    [System.NonSerialized] public bool TestBool4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ResetColour5ToWhite()
    {
        Colour5 = Color.white;
    }

    void ResetColour5ToBlack()
    {
        Colour5 = Color.black;
    }
}
