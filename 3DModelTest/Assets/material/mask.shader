Shader "Custom/dddddd"
{
	Properties
	{
		_Color("Color", Color) = (1,1,1,1)
		_MainTex("Albedo (RGB)", 2D) = "white" {}

	}
		SubShader
	{
		Tags { "RenderType" = "Transparent" "Queue" = "Transparent" }

		zwrite off    //! zwrite�� �⺻������ ���������� Ȯ���ϰ� �ڵ带 ¥�ݴϴ�.
		ColorMask 0    //! �������� �ʽ��ϴ�.
		CGPROGRAM

		#pragma surface surf _NoLit nolight keepalpha noambient noforwardadd nolightmap novertexlights noshadow        //! ����ȭ �ڵ�

		struct Input
		{
			float2 color:COLOR;
		};

		void surf(Input IN, inout SurfaceOutput o)
		{
		}
		float4 Lighting_NoLit(SurfaceOutput s, float3 lightDir, float atten)    //! Ŀ���� ����Ʈ �Լ��� ����� �ƹ��� ������ ���� �ʽ��ϴ�.
		{
			return 0.0f;
		}
		ENDCG


		zwrite off
		CGPROGRAM

		#pragma surface surf Lambert alpha:blend

		sampler2D _MainTex;

		struct Input
		{
			float2 uv_MainTex;
		};

		fixed4 _Color;

		void surf(Input IN, inout SurfaceOutput o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgb;

			o.Alpha = 0.7f;
		}
		ENDCG
	}
		FallBack "Diffuse"
}
