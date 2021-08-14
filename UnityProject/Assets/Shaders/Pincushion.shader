
// Adapted from tutorial: https://www.geeks3d.com/20140213/glsl-shader-library-fish-eye-and-dome-and-barrel-distortion-post-processing-filters/2/

Shader "Custom/Pincushion"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        //Set the range for C1, C2
        _Const("C1", Range(-2, 2)) = 0
        _Constt("C2", Range(-2, 2)) = 0
    }
    SubShader
    {

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
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

			//Vertex shader
            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            uniform sampler2D _MainTex;
            uniform float _Const;
            uniform float _Constt;

			//Radial distortion function
			float2 distort(float2 pos)
			{
				float theta = atan2(pos.y, pos.x);
				float radius = length(pos);

                //Radius update - calculations and constants c1,c2 
                radius = radius + -_Const * pow(radius, 3) + -_Constt * pow(radius, 5);

                //Convert polar to Cartesian coordinates
				pos.x = radius * cos(theta);
				pos.y = radius * sin(theta);

				return 0.5 * (pos + 1.0);
			}

            fixed4 frag (v2f i) : SV_Target
            {
                float2 xy = 2.0 * i.uv - 1.0;
				float2 uv = distort(xy);

                //Texture lookup
				return tex2D(_MainTex, uv);
            }
            ENDCG
        }
    }
}