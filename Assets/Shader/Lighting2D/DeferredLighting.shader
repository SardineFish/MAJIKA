// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

Shader "Lighting2D/DeferredLighting"
{
	Properties
	{
		_MainTex ("Main Texture", 2D) = "white" {}
	}

	// #0 Mix light map
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

			struct v2f
			{
				float4 vertex   : SV_POSITION;
				float2 texcoord  : TEXCOORD0;
			};

			sampler2D _Diffuse;
            sampler2D _MainTex;

			v2f vert(appdata_base IN)
			{
				v2f OUT;
				OUT.vertex = UnityObjectToClipPos(IN.vertex);
				OUT.texcoord = IN.texcoord;
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

		// #1 Gaussian blur
		Pass {
		CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			struct v2f
			{
				float4 vertex   : SV_POSITION;
				float2 texcoord  : TEXCOORD0;
			};

            sampler2D _MainTex;
			float2 _MainTex_TexelSize;

			v2f vert(appdata_base IN)
			{
				v2f OUT;
				OUT.vertex = UnityObjectToClipPos(IN.vertex);
				OUT.texcoord = IN.texcoord;
				return OUT;
			}

			inline float3 filter(float2 uv, float2 d)
			{
				return tex2D(_MainTex, uv + d.xy * _MainTex_TexelSize.x).rgb 
					+ tex2D(_MainTex, uv - d.xy * _MainTex_TexelSize.x).rgb 
					+ tex2D(_MainTex, uv + d.yx * _MainTex_TexelSize.y).rgb
					+ tex2D(_MainTex, uv - d.yx * _MainTex_TexelSize.y).rgb;
			}

			fixed4 frag(v2f IN) : SV_Target
			{
				float2 uv = IN.texcoord;
				float3 col = 0.29234 * tex2D(_MainTex, uv).rgb;
				col += 0.111768 * filter(uv, float2(1, 0));
				col += 0.0499491 * filter(uv, float2(2, 0));
				col += 0.013032 * filter(uv, float2(3, 0));
				col += 0.00198168 * filter(uv, float2(4, 0));
				return fixed4(col, 1.0);
			}
		ENDCG
		}
	}
}