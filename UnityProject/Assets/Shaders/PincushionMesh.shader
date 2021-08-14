// Adapted from tutorial: https://www.geeks3d.com/20140213/glsl-shader-library-fish-eye-and-dome-and-barrel-distortion-post-processing-filters/2/

Shader "Custom/PincushionMesh"
{
	Properties
	{
		_MainTex("Texture", 2D) = "white" {}
		//Set the range for C1, C2
        _Const("C1", Range(-2, 2)) = 0
        _Constt("C2", Range(-2, 2)) = 0
		//Toggle inverse radial distortion on/off
		[Toggle] _Invert("Inverse Distortion Toggle", Float) = 0
	}
	SubShader
	{
		Tags { "RenderType" = "Opaque" }
		LOD 100

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

			sampler2D _MainTex;
			float4 _MainTex_ST;
			float _Invert;
            uniform float _Const;
            uniform float _Constt;


			v2f vert(appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);

                float2 center = float2(0, 0);
                float2 rel = o.vertex.xy - center;
                
                // First pass - predistortion
                //float2 rel = o.vertex.xy / o.vertex.w;
                
                //Radius 
                float radius = length(rel);

                if (radius > 0) {
                    float theta = atan2(rel.y,rel.x);
                    //Predistortion - update radius 
                    radius = radius + _Const * pow(radius, 3) + _Constt * pow(radius, 5);

                    //Inverse distortion - update radius again
					if (_Invert == 1){
						//If C1 and C2 have not yet been set (i.e. no forward distortion has been performed), do not perform inverse distortion
						if (_Const != 0 || _Constt != 0){
						radius = ( (_Const * pow(radius, 2)) + (_Constt * pow(radius, 4)) + (pow(_Const, 2) * pow(radius, 4)) + (pow(_Constt, 2) * pow(radius, 8)) + (2 * _Const * _Constt * pow(radius, 6))) / (1 + (4 * _Const * pow(radius, 2)) + (6 * _Constt  * pow(radius, 4)));
					}
					}
                    
                    // Convert back to Cartesian coordinates
                    rel.x = radius * cos(theta);
                    rel.y = radius * sin(theta);

                }
                o.vertex.xy = rel.xy * o.vertex.w; 


                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                return o;
            }

			fixed4 frag(v2f i) : SV_Target
			{
				fixed4 col = tex2D(_MainTex,  i.uv);
				return col;
			}
			ENDCG
		}
	}
}