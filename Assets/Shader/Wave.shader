// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

Shader "MAJIKA/Effect/Wave" {
    Properties {
        _MainTex ("Main Texture", 2D) = "white" {}
		[PerRendererData] _StartTime ("Start Time", Float) = 0
        [PerRendererData] _Center ("Center", Vector) = (0,0,0,0)
        _TimeScale ("Time Scale", Float) = 1
        _Scale ("Scale", Float) = 0.002
        _Lambda ("Lambda", Float) = 0.5
        _Period ("Period", Float) = 0.2
        _Smooth ("Smooth", Float) = 0.08
        _Damp ("Damp", Range(0,1)) = 0.005 
    }

    SubShader {
        Tags {
            "Queue"="Transparent"
            "RenderType"="Opaque"
        }

        GrabPass { "_ScreenTex" }

        Pass{
            CGPROGRAM

            #include "UnityCG.cginc"
            
            #pragma vertex vert
            #pragma fragment frag

            #define PI      3.14159265358979323846264338327950288419716939937510
            #define LAMBDA  _Lambda
            #define T       _Period
            #define SPEED	(LAMBDA / T)
            #define SMOTH_T 0.1f

            sampler2D _MainTex;
            sampler2D _ScreenTex;
            float4 _ScreenTex_TexelSize;
            float4 _Center;
            float _StartTime;
            float _TimeScale;
            float _Scale;
            float _Lambda;
            float _Period;
            float _Smooth;
            float _Damp;

            struct v2f {
                float4 vert: SV_POSITION;
                float4 screenPos: TEXCOORD0;
                float2 uv: TEXCOORD1;
                float2 worldPos: TEXCOORD2;
            };

            v2f vert(appdata_base v) {
                v2f o;
                o.vert = UnityObjectToClipPos(v.vertex);
                o.screenPos = ComputeGrabScreenPos(o.vert);
                o.worldPos = mul(unity_ObjectToWorld, v.vertex);
                o.uv = v.texcoord;
                return o;
            }

            inline float3 waveGrad(float2 uv)
            {
                float iTime = (_Time.y - _StartTime) * _TimeScale;
                float z = sqrt(uv.x * uv.x + uv.y * uv.y);
                float _2PI = 2. * PI;
                float t = iTime - z / SPEED;
                float3 grad = iTime - z / SPEED <= 0.
                    ? float3(0, 0, -1)
                    : float3(
                        cos(_2PI * t / T) * (_2PI * -2. * uv.x) / (T * SPEED * 2. * z), 
                        cos(_2PI * t / T) * (_2PI * -2. * uv.y) / (T * SPEED * 2. * z), 
                        -1
                        );
                float k = saturate((iTime - z / SPEED) / _Smooth);
                grad = k <= 0 ? grad : grad * k;
                grad.z = t < 0 ? 0 : sin(t * _2PI / T);
                grad.z = grad.z * .5 + .5;
                return grad * pow(_Damp, (iTime - z / SPEED));
            }

            fixed4 frag(v2f i): SV_TARGET {
                float2 uv = i.screenPos.xy / i.screenPos.w;
                
                float3 grad = waveGrad(i.worldPos.xy - _Center);
                float2 delta = grad.xy;
                uv += grad * grad.z * _Scale;

                float3 color = tex2D(_ScreenTex, uv).rgb;
                //float z = sqrt(uv.x * uv.x + uv.y * uv.y);
                //grad = normalize(float3(10 * uv.x * cos(z*10) / z, 10 * uv.y * cos(z*10) / z, -1));
                //color = grad * 0.5 + 0.5;
                return fixed4(color , 1);
            }

            ENDCG
        }
    }
}