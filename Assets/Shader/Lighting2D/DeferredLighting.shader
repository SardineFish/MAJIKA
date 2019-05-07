// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

Shader "Lighting2D/DeferredLighting"
{
	Properties
	{
		_MainTex ("Main Texture", 2D) = "white" {}
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
		Blend One OneMinusSrcAlpha

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
            sampler2D _MainTex;

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
				float3 ambient = UNITY_LIGHTMODEL_AMBIENT;
                float3 color = tex2D(_Diffuse, IN.texcoord);
                float3 light = tex2D(_MainTex, IN.texcoord) + ambient;
                color = color * light;
				return fixed4(color, 1.0);
			}
		ENDCG
		}
	}
}