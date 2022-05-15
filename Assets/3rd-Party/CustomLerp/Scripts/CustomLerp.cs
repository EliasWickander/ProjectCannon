using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LerpMode
{
    EaseInSine,
    EaseOutSine,
    EaseInOutSine,
    EaseInQuad,
    EaseOutQuad,
    EaseInOutQuad,
    EaseInCubic,
    EaseOutCubic,
    EaseInOutCubic,
    EaseInQuart,
    EaseOutQuart,
    EaseInOutQuart,
    EaseInQuint,
    EaseOutQuint,
    EaseInOutQuint,
    EaseInExpo,
    EaseOutExpo,
    EaseInOutExpo,
    EaseInCirc,
    EaseOutCirc,
    EaseInOutCirc,
    EaseInBack,
    EaseOutBack,
    EaseInOutBack,
    EaseInElastic,
    EaseOutElastic,
    EaseInOutElastic,
    EaseInBounce,
    EaseOutBounce,
    EaseInOutBounce,
}

public static class CustomLerp
{

    public static float Lerp(float t, LerpMode mode)
    {
        switch (mode)
        {
            case LerpMode.EaseInSine:
                return EaseInSine(t);
            
            case LerpMode.EaseOutSine:
                return EaseOutSine(t);
            
            case LerpMode.EaseInOutSine:
                return EaseInOutSine(t);
            
            case LerpMode.EaseInQuad:
                return EaseInQuad(t);
            
            case LerpMode.EaseOutQuad:
                return EaseOutQuad(t);
            
            case LerpMode.EaseInOutQuad:
                return EaseInOutQuad(t);
            
            case LerpMode.EaseInCubic:
                return EaseInCubic(t);
            
            case LerpMode.EaseOutCubic:
                return EaseOutCubic(t);
            
            case LerpMode.EaseInOutCubic:
                return EaseInOutCubic(t);
            
            case LerpMode.EaseInQuart:
                return EaseInQuart(t);
            
            case LerpMode.EaseOutQuart:
                return EaseOutQuart(t);
            
            case LerpMode.EaseInOutQuart:
                return EaseInOutQuart(t);
            
            case LerpMode.EaseInQuint:
                return EaseInQuint(t);
            
            case LerpMode.EaseOutQuint:
                return EaseOutQuint(t);
            
            case LerpMode.EaseInOutQuint:
                return EaseInOutQuint(t);
            
            case LerpMode.EaseInExpo:
                return EaseInExpo(t);
            
            case LerpMode.EaseOutExpo:
                return EaseOutExpo(t);
            
            case LerpMode.EaseInOutExpo:
                return EaseInOutExpo(t);
            
            case LerpMode.EaseInCirc:
                return EaseInCirc(t);
            
            case LerpMode.EaseOutCirc:
                return EaseOutCirc(t);
            
            case LerpMode.EaseInOutCirc:
                return EaseInOutCirc(t);
            
            case LerpMode.EaseInBack:
                return EaseInBack(t);
            
            case LerpMode.EaseOutBack:
                return EaseOutBack(t);
            
            case LerpMode.EaseInOutBack:
                return EaseInOutBack(t);
            
            case LerpMode.EaseInElastic:
                return EaseInElastic(t);
            
            case LerpMode.EaseOutElastic:
                return EaseOutElastic(t);
            
            case LerpMode.EaseInOutElastic:
                return EaseInOutElastic(t);
            
            case LerpMode.EaseInBounce:
                return EaseInBounce(t);
            
            case LerpMode.EaseOutBounce:
                return EaseOutBounce(t);
            
            case LerpMode.EaseInOutBounce:
                return EaseInOutBounce(t);
            
            default:
                //This should never happen
                Debug.LogError("Invalid lerp mode");
                return 0;
        }
    }
    
    public static float Lerp(float a, float b, float t, LerpMode mode)
    {
        switch (mode)
        {
            case LerpMode.EaseInSine:
                return EaseInSine(a, b, t);
            
            case LerpMode.EaseOutSine:
                return EaseOutSine(a, b, t);
            
            case LerpMode.EaseInOutSine:
                return EaseInOutSine(a, b, t);
            
            case LerpMode.EaseInQuad:
                return EaseInQuad(a, b, t);
            
            case LerpMode.EaseOutQuad:
                return EaseOutQuad(a, b, t);
            
            case LerpMode.EaseInOutQuad:
                return EaseInOutQuad(a, b, t);
            
            case LerpMode.EaseInCubic:
                return EaseInCubic(a, b, t);
            
            case LerpMode.EaseOutCubic:
                return EaseOutCubic(a, b, t);
            
            case LerpMode.EaseInOutCubic:
                return EaseInOutCubic(a, b, t);
            
            case LerpMode.EaseInQuart:
                return EaseInQuart(a, b, t);
            
            case LerpMode.EaseOutQuart:
                return EaseOutQuart(a, b, t);
            
            case LerpMode.EaseInOutQuart:
                return EaseInOutQuart(a, b, t);
            
            case LerpMode.EaseInQuint:
                return EaseInQuint(a, b, t);
            
            case LerpMode.EaseOutQuint:
                return EaseOutQuint(a, b, t);
            
            case LerpMode.EaseInOutQuint:
                return EaseInOutQuint(a, b, t);
            
            case LerpMode.EaseInExpo:
                return EaseInExpo(a, b, t);
            
            case LerpMode.EaseOutExpo:
                return EaseOutExpo(a, b, t);
            
            case LerpMode.EaseInOutExpo:
                return EaseInOutExpo(a, b, t);
            
            case LerpMode.EaseInCirc:
                return EaseInCirc(a, b, t);
            
            case LerpMode.EaseOutCirc:
                return EaseOutCirc(a, b, t);
            
            case LerpMode.EaseInOutCirc:
                return EaseInOutCirc(a, b, t);
            
            case LerpMode.EaseInBack:
                return EaseInBack(a, b, t);
            
            case LerpMode.EaseOutBack:
                return EaseOutBack(a, b, t);
            
            case LerpMode.EaseInOutBack:
                return EaseInOutBack(a, b, t);
            
            case LerpMode.EaseInElastic:
                return EaseInElastic(a, b, t);
            
            case LerpMode.EaseOutElastic:
                return EaseOutElastic(a, b, t);
            
            case LerpMode.EaseInOutElastic:
                return EaseInOutElastic(a, b, t);
            
            case LerpMode.EaseInBounce:
                return EaseInBounce(a, b, t);
            
            case LerpMode.EaseOutBounce:
                return EaseOutBounce(a, b, t);
            
            case LerpMode.EaseInOutBounce:
                return EaseInOutBounce(a, b, t);
            
            default:
                //This should never happen
                Debug.LogError("Invalid lerp mode");
                return 0;
        }
    }
    
        public static Vector3 Lerp(Vector3 a, Vector3 b, float t, LerpMode mode)
    {
        switch (mode)
        {
            case LerpMode.EaseInSine:
                return EaseInSine(a, b, t);
            
            case LerpMode.EaseOutSine:
                return EaseOutSine(a, b, t);
            
            case LerpMode.EaseInOutSine:
                return EaseInOutSine(a, b, t);
            
            case LerpMode.EaseInQuad:
                return EaseInQuad(a, b, t);
            
            case LerpMode.EaseOutQuad:
                return EaseOutQuad(a, b, t);
            
            case LerpMode.EaseInOutQuad:
                return EaseInOutQuad(a, b, t);
            
            case LerpMode.EaseInCubic:
                return EaseInCubic(a, b, t);
            
            case LerpMode.EaseOutCubic:
                return EaseOutCubic(a, b, t);
            
            case LerpMode.EaseInOutCubic:
                return EaseInOutCubic(a, b, t);
            
            case LerpMode.EaseInQuart:
                return EaseInQuart(a, b, t);
            
            case LerpMode.EaseOutQuart:
                return EaseOutQuart(a, b, t);
            
            case LerpMode.EaseInOutQuart:
                return EaseInOutQuart(a, b, t);
            
            case LerpMode.EaseInQuint:
                return EaseInQuint(a, b, t);
            
            case LerpMode.EaseOutQuint:
                return EaseOutQuint(a, b, t);
            
            case LerpMode.EaseInOutQuint:
                return EaseInOutQuint(a, b, t);
            
            case LerpMode.EaseInExpo:
                return EaseInExpo(a, b, t);
            
            case LerpMode.EaseOutExpo:
                return EaseOutExpo(a, b, t);
            
            case LerpMode.EaseInOutExpo:
                return EaseInOutExpo(a, b, t);
            
            case LerpMode.EaseInCirc:
                return EaseInCirc(a, b, t);
            
            case LerpMode.EaseOutCirc:
                return EaseOutCirc(a, b, t);
            
            case LerpMode.EaseInOutCirc:
                return EaseInOutCirc(a, b, t);
            
            case LerpMode.EaseInBack:
                return EaseInBack(a, b, t);
            
            case LerpMode.EaseOutBack:
                return EaseOutBack(a, b, t);
            
            case LerpMode.EaseInOutBack:
                return EaseInOutBack(a, b, t);
            
            case LerpMode.EaseInElastic:
                return EaseInElastic(a, b, t);
            
            case LerpMode.EaseOutElastic:
                return EaseOutElastic(a, b, t);
            
            case LerpMode.EaseInOutElastic:
                return EaseInOutElastic(a, b, t);
            
            case LerpMode.EaseInBounce:
                return EaseInBounce(a, b, t);
            
            case LerpMode.EaseOutBounce:
                return EaseOutBounce(a, b, t);
            
            case LerpMode.EaseInOutBounce:
                return EaseInOutBounce(a, b, t);
            
            default:
                //This should never happen
                Debug.LogError("Invalid lerp mode");
                return Vector3.zero;
        }
    }
        
    private static float EaseInSine(float t)
    {
        float time = 1 - Mathf.Cos((t * Mathf.PI) * 0.5f);

        return time;
    }
    
    private static float EaseInSine(float a, float b, float t)
    {
        return a + (b - a) * EaseInSine(t);
    }
    
    private static Vector3 EaseInSine(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseInSine(t);
    }

    private static float EaseOutSine(float t)
    {
        float time = Mathf.Sin((t * Mathf.PI) / 2);

        return time;
    }
    
    private static float EaseOutSine(float a, float b, float t)
    {
        return a + (b - a) * EaseOutSine(t);
    }
    
    private static Vector3 EaseOutSine(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseOutSine(t);
    }
    
    private static float EaseInOutSine(float t)
    {
        float time = -(Mathf.Cos(Mathf.PI * t) - 1) / 2;

        return time;
    }
    
    private static float EaseInQuad(float t)
    {
        float time = t * t;

        return time;
    }
    
    private static float EaseOutQuad(float t)
    {
        float time = 1 - (1 - t) * (1 - t);

        return time;
    }
    
    private static float EaseInOutQuad(float t)
    {
        float time;

        if (t < 0.5f)
        {
            time = 2 * t * t;
        }
        else
        {
            time = 1 - Mathf.Pow(-2 * t + 2, 2) * 0.5f;
        }

        return time;
    }
    
    private static float EaseInCubic(float t)
    {
        float time = t * t * t;

        return time;
    }
    
    private static float EaseOutCubic(float t)
    {
        float time = 1 - Mathf.Pow(1 - t, 3);

        return time;
    }
    
    private static float EaseInOutCubic(float t)
    {
        float time;

        if (t < 0.5f)
        {
            time = 4 * t * t * t;
        }
        else
        {
            time = 1 - Mathf.Pow(-2 * t + 2, 3) * 0.5f;
        }

        return time;
    }
    
    private static float EaseInQuart(float t)
    {
        float time = t * t * t * t;

        return time;
    }
    
    private static float EaseOutQuart(float t)
    {
        float time = 1 - Mathf.Pow(1 - t, 4);

        return time;
    }
    
    private static float EaseInOutQuart(float t)
    {
        float time;

        if (t < 0.5f)
        {
            time = 8 * t * t * t * t;
        }
        else
        {
            time = 1 - Mathf.Pow(-2 * t + 2, 4) * 0.5f;
        }

        return time;
    }

    private static float EaseInQuint(float t)
    {
        float time = t * t * t * t * t;

        return time;
    }
    
    private static float EaseOutQuint(float t)
    {
        float time = 1 - Mathf.Pow(1 - t, 5);

        return time;
    }
    
    private static float EaseInOutQuint(float t)
    {
        float time;

        if (t < 0.5f)
        {
            time = 16 * t * t * t * t * t;
        }
        else
        {
            time = 1 - Mathf.Pow(-2 * t + 2, 5) * 0.5f;
        }

        return time;
    }
    
    private static float EaseInExpo(float t)
    {
        float time;

        if (t < 0)
        {
            time = 0;
        }
        else
        {
            time = Mathf.Pow(2, 10 * t - 10);   
        }

        return time;
    }
    
    private static float EaseOutExpo(float t)
    {
        float time;

        if (t == 1)
        {
            time = 1;
        }
        else
        {
            time = 1 - Mathf.Pow(2, -10 * t);
        }

        return time;
    }
    
    private static float EaseInOutExpo(float t)
    {
        float time;

        if (t == 0)
        {
            time = 0;
        }
        else if (t == 1)
        {
            time = 1;
        }
        else
        {
            if (t < 0.5f)
            {
                time = Mathf.Pow(2, 20 * t - 10) * 0.5f;
            }
            else
            {
                time = (2 - Mathf.Pow(2, -20 * t + 10)) * 0.5f;
            }   
        }

        return time;
    }
    
    private static float EaseInCirc(float t)
    {
        float time = 1 - Mathf.Sqrt(1 - Mathf.Pow(t, 2));

        return time;
    }
    
    private static float EaseOutCirc(float t)
    {
        float time = Mathf.Sqrt(1 - Mathf.Pow(t - 1, 2));

        return time;
    }
    
    private static float EaseInOutCirc(float t)
    {
        float time;

        if (t < 0.5f)
        {
            time = (1 - Mathf.Sqrt(1 - Mathf.Pow(2 * t, 2))) * 0.5f;
        }
        else
        {
            time = (Mathf.Sqrt(1 - Mathf.Pow(-2 * t + 2, 2)) + 1) * 0.5f;
        }

        return time;
    }
    
    private static float EaseInBack(float t)
    {
        float c1 = 1.70158f;
        float c3 = c1 + 1;
        
        float time = c3 * t * t * t - c1 * t * t;

        return time;
    }
    
    private static float EaseOutBack(float t)
    {
        float c1 = 1.70158f;
        float c3 = c1 + 1;
        
        float time = 1 + c3 * Mathf.Pow(t - 1, 3) + c1 * Mathf.Pow(t - 1, 2);

        return time;
    }
    
    private static float EaseInOutBack(float t)
    {
        float c1 = 1.70158f;
        float c2 = c1 + 1.525f;
        
        float time;

        if (t < 0.5f)
        {
            time = (Mathf.Pow(2 * t, 2) * ((c2 + 1) * 2 * t - c2)) * 0.5f;
        }
        else
        {
            time = (Mathf.Pow(2 * t - 2, 2) * ((c2 + 1) * (t * 2 - 2) + c2) + 2) * 0.5f;
        }

        return time;
    }
    
    private static float EaseInElastic(float t)
    {
        float c4 = (2 * Mathf.PI) / 3;

        float time;

        if (t == 0)
        {
            time = 0;
        }
        else if (t == 1)
        {
            time = 1;
        }
        else
        {
            time = -Mathf.Pow(2, 10 * t - 10) * Mathf.Sin((t * 10 - 10.75f) * c4);   
        }


        return time;
    }
    
    private static float EaseOutElastic(float t)
    {
        float c4 = (2 * Mathf.PI) / 3;
        
        float time;

        if (t == 0)
        {
            time = 0;
        }
        else if (t == 1)
        {
            time = 1;
        }
        else
        {
            time = Mathf.Pow(2, -10 * t) * Mathf.Sin((t * 10 - 0.75f) * c4) + 1;
        }

        return time;
    }
    
    private static float EaseInOutElastic(float t)
    {
        float c5 = (2 * Mathf.PI) / 4.5f;
        float time;

        if (t == 0)
        {
            time = 0;
        }
        else if (t == 1)
        {
            time = 1;
        }
        else
        {
            if (t < 0.5f)
            {
                time = -(Mathf.Pow(2, 20 * t - 10) * Mathf.Sin((20 * t - 11.125f) * c5)) * 0.5f;
            }
            else
            {
                time = (Mathf.Pow(2, -20 * t + 10) * Mathf.Sin((20 * t - 11.125f) * c5)) * 0.5f + 1;
            }   
        }

        return time;
    }
    
    private static float EaseInBounce(float t)
    {
        float time = 1 - EaseOutBounce(1 - t);

        return time;
    }
    
    private static float EaseOutBounce(float t)
    {
        float n1 = 7.5625f;
        float d1 = 2.75f;

        float time;
        
        if (t < 1 / d1)
        {
            time = n1 * t * t;
        }
        else if (t < 2 / d1)
        {
            time = n1 * (t -= 1.5f / d1) * t + 0.75f;
        }
        else if (t < 2.5f / d1)
        {
            time = n1 * (t -= 2.25f / d1) * t + 0.9375f;
        }
        else
        {
            time = n1 * (t -= 2.625f / d1) * t + 0.984375f;
        }

        return time;
    }
    
    private static float EaseInOutBounce(float t)
    {
        float time;

        if (t < 0.5f)
        {
            time = (1 - EaseOutBounce(1 - 2 * t)) * 0.5f;
        }
        else
        {
            time = (1 + EaseOutBounce(2 * t - 1)) * 0.5f;
        }

        return time;
    }

    private static float EaseInOutSine(float a, float b, float t)
    {
        return a + (b - a) * EaseInOutSine(t);
    }
    
    private static float EaseInQuad(float a, float b, float t)
    {
        return a + (b - a) * EaseInQuad(t);
    }
    
    private static float EaseOutQuad(float a, float b, float t)
    {
        return a + (b - a) * EaseOutQuad(t);
    }
    
    private static float EaseInOutQuad(float a, float b, float t)
    {
        return a + (b - a) * EaseInOutQuad(t);
    }
    
    private static float EaseInCubic(float a, float b, float t)
    {
        return a + (b - a) * EaseInCubic(t);
    }
    
    private static float EaseOutCubic(float a, float b, float t)
    {
        return a + (b - a) * EaseOutCubic(t);
    }
    
    private static float EaseInOutCubic(float a, float b, float t)
    {
        return a + (b - a) * EaseInOutCubic(t);
    }
    
    private static float EaseInQuart(float a, float b, float t)
    {
        return a + (b - a) * EaseInQuart(t);
    }
    
    private static float EaseOutQuart(float a, float b, float t)
    {
        return a + (b - a) * EaseOutQuart(t);
    }
    
    private static float EaseInOutQuart(float a, float b, float t)
    {
        return a + (b - a) * EaseInOutQuart(t);
    }
    
    private static float EaseInQuint(float a, float b, float t)
    {
        return a + (b - a) * EaseInQuint(t);
    }
    
    private static float EaseOutQuint(float a, float b, float t)
    {
        return a + (b - a) * EaseOutQuint(t);
    }
    
    private static float EaseInOutQuint(float a, float b, float t)
    {
        return a + (b - a) * EaseInOutQuint(t);
    }
    
    private static float EaseInExpo(float a, float b, float t)
    {
        return a + (b - a) * EaseInExpo(t);
    }
    
    private static float EaseOutExpo(float a, float b, float t)
    {
        return a + (b - a) * EaseOutExpo(t);
    }
    
    private static float EaseInOutExpo(float a, float b, float t)
    {
        return a + (b - a) * EaseInOutExpo(t);
    }
    
    private static float EaseInCirc(float a, float b, float t)
    {
        return a + (b - a) * EaseInCirc(t);
    }
    
    private static float EaseOutCirc(float a, float b, float t)
    {
        return a + (b - a) * EaseOutCirc(t);
    }
    
    private static float EaseInOutCirc(float a, float b, float t)
    {
        return a + (b - a) * EaseInOutCirc(t);
    }
    
    private static float EaseInBack(float a, float b, float t)
    {
        return a + (b - a) * EaseInBack(t);
    }
    
    private static float EaseOutBack(float a, float b, float t)
    {
        return a + (b - a) * EaseOutBack(t);
    }
    
    private static float EaseInOutBack(float a, float b, float t)
    {
        return a + (b - a) * EaseInOutBack(t);
    }
    
    private static float EaseInElastic(float a, float b, float t)
    {
        return a + (b - a) * EaseInElastic(t);
    }
    
    private static float EaseOutElastic(float a, float b, float t)
    {
        return a + (b - a) * EaseOutElastic(t);
    }
    
    private static float EaseInOutElastic(float a, float b, float t)
    {
        return a + (b - a) * EaseInOutElastic(t);
    }

    private static float EaseInBounce(float a, float b, float t)
    {
        return a + (b - a) * EaseInBounce(t);
    }
    
    private static float EaseOutBounce(float a, float b, float t)
    {
        return a + (b - a) * EaseOutBounce(t);
    }

    private static float EaseInOutBounce(float a, float b, float t)
    {
        return a + (b - a) * EaseInOutBounce(t);
    }

    private static Vector3 EaseInOutSine(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseInOutSine(t);
    }
    
    private static Vector3 EaseInQuad(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseInQuad(t);
    }
    
    private static Vector3 EaseOutQuad(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseOutQuad(t);
    }
    
    private static Vector3 EaseInOutQuad(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseInOutQuad(t);
    }
    
    private static Vector3 EaseInCubic(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseInCubic(t);
    }
    
    private static Vector3 EaseOutCubic(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseOutCubic(t);
    }
    
    private static Vector3 EaseInOutCubic(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseInOutCubic(t);
    }
    
    private static Vector3 EaseInQuart(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseInQuart(t);
    }
    
    private static Vector3 EaseOutQuart(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseOutQuart(t);
    }
    
    private static Vector3 EaseInOutQuart(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseInOutQuart(t);
    }
    
    private static Vector3 EaseInQuint(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseInQuint(t);
    }
    
    private static Vector3 EaseOutQuint(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseOutQuint(t);
    }
    
    private static Vector3 EaseInOutQuint(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseInOutQuint(t);
    }
    
    private static Vector3 EaseInExpo(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseInExpo(t);
    }
    
    private static Vector3 EaseOutExpo(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseOutExpo(t);
    }
    
    private static Vector3 EaseInOutExpo(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseInOutExpo(t);
    }
    
    private static Vector3 EaseInCirc(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseInCirc(t);
    }
    
    private static Vector3 EaseOutCirc(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseOutCirc(t);
    }
    
    private static Vector3 EaseInOutCirc(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseInOutCirc(t);
    }
    
    private static Vector3 EaseInBack(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseInBack(t);
    }
    
    private static Vector3 EaseOutBack(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseOutBack(t);
    }
    
    private static Vector3 EaseInOutBack(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseInOutBack(t);
    }
    
    private static Vector3 EaseInElastic(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseInElastic(t);
    }
    
    private static Vector3 EaseOutElastic(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseOutElastic(t);
    }
    
    private static Vector3 EaseInOutElastic(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseInOutElastic(t);
    }

    private static Vector3 EaseInBounce(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseInBounce(t);
    }
    
    private static Vector3 EaseOutBounce(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseOutBounce(t);
    }

    private static Vector3 EaseInOutBounce(Vector3 a, Vector3 b, float t)
    {
        return a + (b - a) * EaseInOutBounce(t);
    }
}
