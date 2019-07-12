Shader "MAJIKA/FX/PixelPartical"
{
    Properties
    {
        _MainTex ("Particals Texture", 2D) = "white" {}
        _Color ("Color", Color) = (1, 1, 1, 1)
        _Column ("Column", Int) = 1
        _Row ("Row", Int) = 1
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
        Fog { Mode Off }
        Blend SrcAlpha OneMinusSrcAlpha

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
                float4 color : COLOR;
            };

            struct v2f
            {
                float4 color : COLOR;
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;

            int _Column;
            int _Row;
            float4 _Color;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                o.color = v.color;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                //i.uv.x /= _Column;
                //i.uv.y /= _Row;
                float4 color = tex2D(_MainTex, i.uv).rgba * _Color * i.color;

                return color;
            }
            ENDCG
        }
    }
}
