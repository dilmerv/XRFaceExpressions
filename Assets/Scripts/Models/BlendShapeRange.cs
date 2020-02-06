using System;

[Serializable]
public class BlendShapeRange 
{
    public BlendShapeLocationEnum BlendShape = BlendShapeLocationEnum.NoSet;
    public float LowBound = 0;
    public float UpperBound = 0;
    public int DetectionCount = 0;
    public ActionExecutor Action;
}