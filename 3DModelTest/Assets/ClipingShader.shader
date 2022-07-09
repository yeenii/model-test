Shader "Custom/ClipingShader" //shader¿Ã∏ß
{
	Properties
	{
		_Color("Color", Color) = (1,1,1,1)
		_MainTex("Base (RGB) Trans (A)", 2D) = "white" {}
		


			[HDR] _CutoffColor("Cutoff Color", Color) = (1,0,0,0)
	}
		SubShader
		{
			Tags {"Queue" = "Transparent" "IgnoreProjector" = "True" "RenderType" = "Transparent"}
			LOD 200

			Cull off
			Pass {
		ZWrite On
		ColorMask 0
		}
		
			

			CGPROGRAM
			// Physically based Standard lighting model, and enable shadows on all light types
			#pragma surface surf Standard fullforwardshadows

			// Use shader model 3.0 target, to get nicer looking lighting
			#pragma target 3.0

			sampler2D _MainTex;

			fixed4 _Color;

			float4 _Plane;
			float4 _CutoffColor;


			struct Input
			{
				float2 uv_MainTex;
				float3 worldPos;
				float facing : VFACE;
			};


			void surf(Input IN, inout SurfaceOutputStandard o)
			{
				

				float facing = IN.facing * 0.5 + 0.5;


				// Albedo comes from a texture tinted by color
				fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
				o.Albedo = c.rgb;
				// Metallic and smoothness come from slider variables
			
				o.Alpha = c.a;
			}
			ENDCG

				UsePass "Transparent/Diffuse/FORWARD"
		}
			FallBack "Diffuse"
}