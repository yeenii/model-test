Shader "Custom/TwoPass"
{
    Properties
    {
		_Color("Main Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
       
    }
    SubShader
    {
		Tags {"Queue" = "Transparent" "IgnoreProjector" = "True" "RenderType" = "Transparent"}
        LOD 200

		zwrite on
		ColorMask 0

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

       

        struct Input
        {
			float4 color:COLOR;
        };


        void surf (Input IN, inout SurfaceOutputStandard o)
        {
     
        }

		float4 Lightingnolight(SurfaceOutput s, float3 lightDir, float atten)
		{
			return float4(0, 0, 0, 0);
		}

		ENDCG

		zwrite off

		CGPROGRAM
        #pragma surface surf Lambert alpha:fade

		sampler2D _MainTex;

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutput o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = 0.5;
		}
		ENDCG

    }
    FallBack "Diffuse"
}
