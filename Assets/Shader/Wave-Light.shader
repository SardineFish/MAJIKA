// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

Shader "MAJIKA/Effect/Wave-Light" {
    Properties {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Main Texture", 2D) = "white" {}
		[PerRendererData] _StartTime ("Start Time", Float) = 0
        [PerRendererData] _Center ("Center", Vector) = (0,0,0,0)
        _TimeScale ("Time Scale", Float) = 1
        _Scale ("Scale", Float) = 0.002
        _Lambda ("Lambda", Float) = 0.5
        _Period ("Period", Float) = 0.2
        _Smooth ("Smooth", Float) = 0.08
        _TimeDamp ("Time Damp", Range(0,1)) = 0.6
        _DistanceDamp ("Distance Damp", Range(0,1)) = 0.6
    }

    SubShader {
        Tags {
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }

        Pass{

            ZWrite Off
            Blend SrcAlpha OneMinusSrcAlpha


            CGPROGRAM

            #include "UnityCG.cginc"
            
            #pragma vertex vert
            #pragma fragment frag

            #define PI      3.14159265358979323846264338327950288419716939937510
            #define LAMBDA  _Lambda
            #define T       _Period
            #define SPEED	(LAMBDA / T)

            float4 _Color;
            sampler2D _MainTex;
            sampler2D _ScreenTex;
            float4 _ScreenTex_TexelSize;
            float4 _Center;
            float _StartTime;
            float _TimeScale;
            float _Scale;
            float _Lambda;
            float _Period;
            float _TimeDamp;
            float _DistanceDamp;

            struct v2f {
                float4 vert: SV_POSITION;
                float2 uv: TEXCOORD1;
                float2 worldPos: TEXCOORD2;
            };

            v2f vert(appdata_base v) {
                v2f o;
                o.vert = UnityObjectToClipPos(v.vertex);
                o.worldPos = mul(unity_ObjectToWorld, v.vertex);
                o.uv = v.texcoord;
                return o;
            }

            inline float wave(float2 uv)
            {
                float iTime = (_Time.y - _StartTime) * _TimeScale;
                float z = sqrt(uv.x * uv.x + uv.y * uv.y);
                float _2PI = 2. * PI;
                float t = (iTime - z / SPEED) / T;
                
                return t <= 0
                    ? 0
                    : (1 - frac(t)) * pow(_TimeDamp, t) * pow(_DistanceDamp, z);
            }

            fixed4 frag(v2f i): SV_TARGET {
                float w = wave(i.worldPos.xy - _Center);

                return fixed4(_Color.rgb, _Color.a * w);
            }

            ENDCG
        }
    }
}