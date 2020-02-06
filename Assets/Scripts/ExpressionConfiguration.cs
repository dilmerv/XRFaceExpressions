using UnityEngine;

[CreateAssetMenu(fileName = "Expression", menuName = "Expressions/Create Expression", order = 1)]
public class ExpressionConfiguration : ScriptableObject
{
    public string ExpresionName;

    [SerializeField]
    public BlendShapeRange[] BlendShapeRanges;

    [SerializeField]
    public ActionExecutor Action;
}