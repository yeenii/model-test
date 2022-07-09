Shader "Custom/ZBufferShader"
{
    
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _CameraDepthTexture;

        struct Input
        {
            float4 screenPos;
        };

       
        void surf (Input IN, inout SurfaceOutputStandard o)
        {
			float2 sPos = float2(IN.screenPos.x, IN.screenPos.y);
			float4 depth = tex2D(_CameraDepthTexture, sPos);
			o.Emission = depth.r;
			o.Alpha = 1;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
