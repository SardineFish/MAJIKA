Shader "Custom/Particle-Shader" {
	Properties {
		_Texture("Texture", 2D) = "defaulttexture" {}
		_Column("Column", Int) = 1
		_Row("Row", Int) = 1
	}
	SubShader {
		Tags {"RenderType"="Transparent" "Queue"="Transparent"}
		
		Pass {

			CGPROGRAM

			#pragma vertex vert

			#pragma fragment frag


			// Use shader model 3.0 target, to get nicer looking lighting
			#pragma target 3.0

			sampler2D _MainTex;

			struct Input {
        	    float4 vertex :POSITION;
				float3 uv :TEXCOORD0;
			};

			struct v2f {
				float4 vertex :SV_POSITION;
				float2 uv :TEXCOORD0;
			};

			sampler2D _Texture;
			int _Column;
			int _Row;

			v2f vert(Input input)
			{
				v2f output;
				output.vertex = UnityObjectToClipPos(input.vertex);
				float2 uv = input.uv.xy;
				int total = _Column * _Row;
				int x = 0;//(input.uv.z * total) % _Column;
				int y = 0;// (input.uv.z * total) / _Column;
				output.uv.x = input.uv.x;// / _Column;
				output.uv.y = input.uv.y;// / _Row;
				return output;
			}

			fixed4 frag(v2f input): SV_Target
			{
				return tex2D(_Texture, input.uv);
			}


			ENDCG
		}
		
	}
	FallBack "Diffuse"
}
