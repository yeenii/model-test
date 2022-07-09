Shader "Custom/Mask"
{
	SubShader
	{
		Tags{"Queue" = "Transparent+1"}

		Pass{
		//Blend SrcAlpha OneMinusSrcAlpha
		Blend Zero One
		 }

	}
}