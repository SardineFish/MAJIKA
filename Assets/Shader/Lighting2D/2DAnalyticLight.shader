// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

Shader "Lighting2D/AnalyticLight"
{
	Properties
	{
        _Color("Color", Color) = (1,1,1,1)
		_ConstantFactor("Constant Factor", Range(0, 1)) = 1
		_LinearFactor("Linear Factor", Range(0, 1)) = 1
		_QuadraticFactor("Quadratic Factor", Range(0, 1)) = 1
		_Scale("Scale", Float) = 1
	}

	SubShader
	{
		Tags
		{ 
			"Queue"="Transparent" 
			"IgnoreProjector"="True" 
			"RenderType"="Transparent" 
			"PreviewType"="Plane"
			"CanUseSpriteAtlas"="True"
		}

		Cull Off
		Lighting Off
		ZWrite Off
		Blend One One

		Pass
		{
		CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"
			
			struct appdata_t
			{
				float4 vertex   : POSITION;
				float4 color    : COLOR;
				float2 texcoord : TEXCOORD0;
			};

			struct v2f
			{
				float4 vertex   : SV_POSITION;
				fixed4 color    : COLOR;
				float2 texcoord  : TEXCOORD0;
                float4 worldPos:TEXCOORD1;
			};
			
			fixed4 _Color;

			sampler2D _Diffuse;
			float4 _2DLightPos;
            float _LightRange;
            float _Intensity;
			float _ConstantFactor;
			float _LinearFactor;
			float _QuadraticFactor;
			float _Scale;

			v2f vert(appdata_t IN)
			{
				v2f OUT;
				OUT.vertex = UnityObjectToClipPos(IN.vertex);
				OUT.texcoord = ComputeScreenPos(OUT.vertex);
				OUT.color = IN.color * _Color;
                OUT.worldPos = mul(unity_ObjectToWorld, IN.vertex);

				return OUT;
			}

			fixed4 frag(v2f IN) : SV_Target
			{
				float3 diffuse = tex2D(_Diffuse, IN.texcoord);
                float d = distance(IN.worldPos, _2DLightPos);
                d /= _LightRange;
                d = saturate(d);
                float3 illum = exp(-d * _Scale) - exp(-_Scale) * d;
				illum *= _Intensity * _Color;
                float3 color = illum;
				return fixed4(color, 1.0);
			}
		ENDCG
		}
	}
}